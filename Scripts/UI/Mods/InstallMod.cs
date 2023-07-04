using Godot;
using System;

public class InstallMod : TextureButton {
    FileDialog folderDialog;
    string modPath;

    public override void _Ready() {
        CanvasLayer coolThingy = new CanvasLayer();
        coolThingy.Layer = 128;
        folderDialog = new FileDialog();
        folderDialog.Mode = FileDialog.ModeEnum.OpenDir;
        folderDialog.Access = FileDialog.AccessEnum.Filesystem;

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
        install.MakeDir($"user://mods/{pureIncompetence[pureIncompetence.Length-1]}");

        CopyFolder(epicCoolMod, $"user://mods/{pureIncompetence[pureIncompetence.Length-1]}/");

        GD.Print("successfully installed mod");
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

    public void Click() {
        folderDialog.Popup_();
        folderDialog.RectPosition = new Vector2(140, 60);
        folderDialog.RectMinSize = new Vector2(1000, 600);
    }
}
