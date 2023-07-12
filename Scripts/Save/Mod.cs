using System;
using System.Collections.Generic;
using Godot;
using Newtonsoft.Json;

public class Mod : Node2D {
    public override void _Ready() {
        // load cool mods :)
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
        }

        foreach (var coolMod in mods) {
            // now we have to find a script
            File modfile = new File();
            if (modfile.FileExists($"user://mods/{coolMod}/main.tscn")) {
                // don't load a mod for a different version of the game, wouldn't be cool tee bee eich
                if (modfile.Open($"user://mods/{coolMod}/modinfo.json", File.ModeFlags.Read) == Error.Ok) {
                    string j = JsonConvert.DeserializeObject<ModInfo>(modfile.GetAsText()).GameVersion;
                    if (j == "1.1.0") {
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
                }
            }
        }
        base._Ready();
    }
}