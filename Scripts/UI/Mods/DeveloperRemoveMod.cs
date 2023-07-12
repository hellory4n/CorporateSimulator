using Godot;
using System;
using Newtonsoft.Json;

public class DeveloperRemoveMod : TextureButton {
    string modPath;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        // find the name of the main node so we can stop running it
        File gjhjf = new File();
        string mainNode = "";
        if (gjhjf.Open($"{modPath}/modinfo.json", File.ModeFlags.Read) == Error.Ok) {
            mainNode = JsonConvert.DeserializeObject<ModInfo>(gjhjf.GetAsText()).MainNode;
        } else {
            GD.PushWarning("Mod seems to be broken");
        }

        // stop the mod from running
        GetNode<Node2D>($"/root/{mainNode}").QueueFree();

        string[] pureIncompetence = Global.DeveloperMod.Split("/");
        string coolMod = pureIncompetence[pureIncompetence.Length-1];
        modPath = $"user://mods/{coolMod}/";

        DeleteFolder(modPath);
        // delete the folder itself
        Directory m = new Directory();
        m.Remove(modPath);
    }

    public void DeleteFolder(string path) {
        Directory dir = new Directory();
        if (dir.Open(path) == Error.Ok) {
            dir.ListDirBegin(true);
            string filename = dir.GetNext();
            while (filename != "") {
                if (dir.CurrentIsDir()) {
                    GD.Print($"deleting {path}/{filename}");
                    DeleteFolder($"{path}/{filename}");
                    dir.Remove($"{path}/{filename}/");
                }
                else {
                    GD.Print($"deleting {path}/{filename}");
                    dir.Remove($"{path}/{filename}");
                }
                filename = dir.GetNext();
            }
        } else {
            GD.PushWarning($"Error deleting {path}");
        }
    }
}
