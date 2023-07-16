using Godot;
using System;
using Newtonsoft.Json;

public class DeveloperInstallMod : TextureButton {
    FileDialog folderDialog;
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (Global.DeveloperMod != "nothing") {
            // folder stuff or something idk lol
            Directory source = new Directory();
            source.Open(Global.DeveloperMod);
            Directory install = new Directory();
            string[] pureIncompetence = Global.DeveloperMod.Split("/");
            string coolMod = pureIncompetence[pureIncompetence.Length-1];

            // don't install an incompatible mod :)
            File gjhjf = new File();
            if (gjhjf.Open($"{Global.DeveloperMod}/modinfo.json", File.ModeFlags.Read) == Error.Ok) {
                string j = JsonConvert.DeserializeObject<ModInfo>(gjhjf.GetAsText()).GameVersion;
                if (j == "1.1.0") {
                    install.MakeDir($"user://mods/{coolMod}");
                    CopyFolder(Global.DeveloperMod, $"user://mods/{coolMod}/");
                    
                    // run the mod so the user doesn't have to restart the game
                    File modfile = new File();
                    if (modfile.FileExists($"user://mods/{coolMod}/main.tscn")) {
                        var yes = (PackedScene)ResourceLoader.Load($"user://mods/{coolMod}/main.tscn");
                        GD.Print("Loaded mod: " + coolMod);
                        Node2D OK = (Node2D)yes.Instance();
                        GetTree().Root.CallDeferred("add_child", OK);
                    }
                    
                    GD.Print("successfully installed mod");
                } else {
                    GetNode<Label>("./Label").Text = "Incompatible Mod!";
                }
            } else {
                GetNode<Label>("./Label").Text = "Broken Mod!";
            }
        } else {
            GetNode<Label>("./Label").Text = "Choose a mod!";
        }
    }

    public void CopyFolder(string from, string to) {
        Directory dir = new Directory();
        if (!dir.DirExists(to))
            dir.MakeDirRecursive(to);
        if (dir.Open(from) == Error.Ok) {
            dir.ListDirBegin(true);
            string filename = dir.GetNext();
            while (filename != "") {
                if (dir.CurrentIsDir()) {
                    // copying the source control stuff wouldn't be nice
                    // also don't copy folders that just waste space
                    if (filename != ".git" && filename != ".hg" && filename != ".svn" && filename != ".tfvc"
                    && filename != ".mono" && filename != ".vscode" && filename != "")
                        CopyFolder($"{from}/{filename}", $"{to}/{filename}");
                } else {
                    // godot makes the mod's files refer to res://, which when running the mod would result in the
                    // game looking for the files in the game folder and not the mod folder, causing a crash
                    // this is probably stupid

                    // only convert files if they probably reference paths with res://
                    if (filename.EndsWith(".tres") || filename.EndsWith(".tscn") || filename.EndsWith(".import") ||
                    filename.EndsWith(".gd")) {
                        File ye = new File();
                        ye.Open($"{from}/{filename}", File.ModeFlags.Read);
                        string hmues = ye.GetAsText();
                        string[] coolLines = hmues.Split("\n");
                        string newContent = "";
                        foreach (var line in coolLines) {
                            // allow mods still access the game's files
                            if (!line.EndsWith("# CS PATH")) {
                                newContent += line.Replace("res://", to) + "\n";
                            } else {
                                newContent += line;
                            }
                        }
                        ye.Close();

                        File j = new File();
                        j.Open($"{to}/{filename}", File.ModeFlags.Write);
                        j.StoreString(newContent);
                        j.Close();
                    } else {
                        dir.Copy($"{from}/{filename}", $"{to}/{filename}");
                    }
                }
                filename = dir.GetNext();
            }
        } else {
            GD.PushWarning($"Error copying {from} to {to}");
        }
    }
}
