using Godot;
using System;

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
            if (gjhjf.Open($"{Global.DeveloperMod}/cs-version", File.ModeFlags.Read) == Error.Ok) {
                string j = gjhjf.GetAsText();
                if (j.StartsWith("1.1.0")) {
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
                if (dir.CurrentIsDir())
                    CopyFolder($"{from}/{filename}", $"{to}/{filename}");
                else
                    dir.Copy($"{from}/{filename}", $"{to}/{filename}");
                filename = dir.GetNext();
            }
        } else {
            GD.PushWarning($"Error copying {from} to {to}");
        }
    }
}
