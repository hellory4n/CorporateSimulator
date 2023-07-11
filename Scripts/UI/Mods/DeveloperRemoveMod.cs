using Godot;
using System;

public class DeveloperRemoveMod : TextureButton {
    string modPath;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        string[] pureIncompetence = Global.DeveloperMod.Split("/");
        string coolMod = pureIncompetence[pureIncompetence.Length-1];
        modPath = $"user://mods/{coolMod}/";

        DeleteFolder(modPath);
        // delete the folder itself
        Directory m = new Directory();
        m.Remove(modPath);

        // stop the mod from running :)
        string coolNode = GetNode<LineEdit>("../MainNode").Text;
        if (GetNodeOrNull<Node2D>($"/root/{coolNode}") != null) {
            GetNode<Node2D>($"/root/{coolNode}").QueueFree();
        } else {
            GD.PushWarning($"Failed to stop running \"{coolMod}\"");
        }
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
