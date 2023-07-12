using Godot;
using System;
using Newtonsoft.Json;

public class RemoveMod : TextureButton {
    string modPath;

    public void Init(string bruh) {
        modPath = bruh; // you're welcome
    }

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

        DeleteFolder(modPath);
        // delete the folder itself
        Directory m = new Directory();
        m.Remove(modPath);
        
        // restart the mod list
        var myes = (PackedScene)ResourceLoader.Load("res://Scenes/ModManager.tscn");
        Node2D mOK = (Node2D)myes.Instance();
        mOK.ZIndex = 100;
        GetTree().Root.AddChild(mOK);
        GetParent().GetParent().GetParent().GetParent().GetParent().QueueFree();
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
