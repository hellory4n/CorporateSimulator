using Godot;
using System;
using Newtonsoft.Json;

public class InstallMod : TextureButton {
    FileDialog folderDialog;

    public override void _Ready() {
        CanvasLayer coolThingy = new CanvasLayer();
        coolThingy.Layer = 128;
        folderDialog = new FileDialog();
        folderDialog.Mode = FileDialog.ModeEnum.OpenDir;
        folderDialog.Access = FileDialog.AccessEnum.Filesystem;
        // make it be stuck in a specific place forever
        folderDialog.MouseFilter = Control.MouseFilterEnum.Ignore;

        // make it not look like shit
        folderDialog.Theme = ResourceLoader.Load<Theme>("res://Scripts/UI/epiccoolthemething.tres");

        // use the correct home folder
        if (OS.GetName() == "Android")
            folderDialog.CurrentDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        else
            folderDialog.CurrentDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);

        folderDialog.Connect("dir_selected", this, nameof(OnFolderSelected));
        AddChild(coolThingy);
        coolThingy.AddChild(folderDialog);
        this.Connect("pressed", this, nameof(Click));
    }

    public void OnFolderSelected(string epicCoolMod) {
        // folder stuff or something idk lol
        Directory source = new Directory();
        source.Open(epicCoolMod);
        Directory install = new Directory();
        string[] pureIncompetence = epicCoolMod.Split("/");
        string coolMod = pureIncompetence[pureIncompetence.Length-1];

        // don't install an incompatible mod :)
        File gjhjf = new File();
        if (gjhjf.Open($"{epicCoolMod}/modinfo.json", File.ModeFlags.Read) == Error.Ok) {
            string j = JsonConvert.DeserializeObject<ModInfo>(gjhjf.GetAsText()).GameVersion;
            if (j == "1.1.0") {
                install.MakeDir($"user://mods/{coolMod}");
                CopyFolder(epicCoolMod, $"user://mods/{coolMod}/");
                
                // run the mod so the user doesn't have to restart the game
                File modfile = new File();
                if (modfile.FileExists($"user://mods/{coolMod}/main.tscn")) {
                    var yes = (PackedScene)ResourceLoader.Load($"user://mods/{coolMod}/main.tscn");
                    GD.Print("Loaded mod: " + coolMod);
                    Node2D OK = (Node2D)yes.Instance();
                    GetTree().Root.CallDeferred("add_child", OK);
                }
                
                GD.Print("successfully installed mod");

                // restart the mod list
                var myes = (PackedScene)ResourceLoader.Load("res://Scenes/ModManager.tscn");
                Node2D mOK = (Node2D)myes.Instance();
                mOK.ZIndex = 100;
                GetTree().Root.AddChild(mOK);
                // i have to do weird things to make the ui look right
                GetParent().GetParent().GetParent().GetParent().GetParent().QueueFree();
            } else {
                GetNode<Label>("./Label").Text = "Incompatible Mod!";
            }
            gjhjf.Close();
        } else {
            GetNode<Label>("./Label").Text = "Broken Mod!";
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
            dir.ListDirEnd();
        } else {
            GD.PushWarning($"Error copying {from} to {to}");
        }
    }

    public void Click() {
        folderDialog.Popup_();
        folderDialog.RectPosition = new Vector2(140, 60);
        folderDialog.RectMinSize = new Vector2(1000, 600);
    }
}
