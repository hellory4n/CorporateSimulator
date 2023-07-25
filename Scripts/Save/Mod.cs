using System;
using System.Collections.Generic;
using Godot;
using Newtonsoft.Json;
using System.Linq;
using System.Text.RegularExpressions;

public class Mod : Node2D {
    public override void _Ready() {
        // first we check if the latest log file has an error, this is so if you install a broken mod the game
        // won't always crash when opening it
        // first it find the latest log file, godot.log is the current file but we don't want that
        bool somethingWrongIsNotCorrect = false;

        // make a cool file list :)
        Directory pain = new Directory();
        List<string> logFiles = new List<string>();
        pain.Open("user://logs/");
        pain.ListDirBegin(true);
        string filename = pain.GetNext();
        while (filename != "") {
            logFiles.Add(filename);
            filename = pain.GetNext();
        }
        pain.ListDirEnd();

        // when the uhhhhhhhhhhh when the you know when it happens it does happen like that pretty suddenly when
        // the umm the the uhh the thing happens
        var sortedLogFiles = logFiles.Where(f => Regex.IsMatch(f, @"^godot\d{4}-\d{2}-\d{2}T\d{2}\.\d{2}\.\d{2}\.log$"))
                                     .OrderByDescending(f => GetDateTimeFromFilename(f))
                                     .ToList();
        
        string latestFileOmgogogmog = "nuh uh";
        if (sortedLogFiles.Count > 0) {
            latestFileOmgogogmog = sortedLogFiles[0];
        }

        // load the file and check if there's anything suspicious among us
        File thissucks = new File();
        if (thissucks.Open($"user://logs/{latestFileOmgogogmog}", File.ModeFlags.Read) == Error.Ok) {
            string coolLogs = thissucks.GetAsText();
            if (coolLogs.Contains("ERROR: ")) {
                somethingWrongIsNotCorrect = true;
            }
            thissucks.Close();
        }

        // only load cool mods if something didn't go very wrong :)
        if (!somethingWrongIsNotCorrect) {
            Directory modfolder = new Directory();
            List<string> mods = new List<string>();
            if (modfolder.DirExists("user://mods")) {
                GD.Print("mods exist");
                modfolder.Open("user://mods/");

                // find what mods exist
                modfolder.ListDirBegin(true);
                while (true) {
                    string nextFolder = modfolder.GetNext();
                    // don't keep looking for mods forever, that would be bad
                    if (nextFolder == "")
                        break;
                    
                    if (modfolder.CurrentIsDir()) {
                        mods.Add(nextFolder);
                    }
                }
                modfolder.ListDirEnd();
            }

            foreach (var coolMod in mods) {
                // now we have to find a script
                File modfile = new File();
                if (modfile.FileExists($"user://mods/{coolMod}/main.tscn")) {
                    // don't load a mod for a different version of the game, wouldn't be cool tee bee eich
                    if (modfile.Open($"user://mods/{coolMod}/modinfo.json", File.ModeFlags.Read) == Error.Ok) {
                        string j = JsonConvert.DeserializeObject<ModInfo>(modfile.GetAsText()).GameVersion;
                        if (j != "1.1.0") {
                            Global.IncompatibleMod = coolMod;
                            Global.IncompatibleModVersion = j;
                            var ye2s = (PackedScene)ResourceLoader.Load($"res://Scenes/IncompatibleMod.tscn");
                            Node2D O2K = (Node2D)ye2s.Instance();
                            GetTree().Root.CallDeferred("add_child", O2K);
                        } else {
                            var yes = (PackedScene)ResourceLoader.Load($"user://mods/{coolMod}/main.tscn");
                            GD.Print("Loaded mod: " + coolMod);
                            Node2D OK = (Node2D)yes.Instance();
                            GetTree().Root.CallDeferred("add_child", OK);
                        }
                        modfile.Close();
                    }
                }
            }
        } else {
            var ohnoes = (PackedScene)ResourceLoader.Load("res://Scenes/BrokenMod.tscn");
            Control ohshoes = (Control)ohnoes.Instance();
            GetTree().Root.CallDeferred("add_child", ohshoes);
        }
        base._Ready();
    }

    DateTime GetDateTimeFromFilename(string filename) {
        // skip godot prefix and .log suffix
        string timestamp = filename.Substring(5, 19);
        return DateTime.ParseExact(timestamp, "yyyy-MM-ddTHH.mm.ss", null);
    }
}