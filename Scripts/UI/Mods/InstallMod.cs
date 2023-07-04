using Godot;
using System;

public class InstallMod : TextureButton {
    FileDialog folderDialog;
    string modName;

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
        modName = System.IO.Path.GetFileName(epicCoolMod);
        System.IO.Directory.CreateDirectory($"{OS.GetUserDataDir()}/mods/{modName}/");
        CopyFolder(epicCoolMod);
        GD.Print("successfully installed mod");
    }

    public void CopyFolder(string epicCoolMod) {
        string[] files = System.IO.Directory.GetFiles(epicCoolMod);
        foreach (string file in files) {
            string fileName = System.IO.Path.GetFileName(file);
            string destinationFile = System.IO.Path.Combine(OS.GetUserDataDir()+"/mods/"+modName+"/", fileName);
            System.IO.File.Copy(file, destinationFile, true);
        }

        // we need this so you can have a mod with folders
        string[] subfolders = System.IO.Directory.GetDirectories(epicCoolMod);
        foreach (string subfolder in subfolders) {
            string folderName = System.IO.Path.GetFileName(subfolder);
            string destinationSubfolder = System.IO.Path.Combine(epicCoolMod, folderName);
            CopyFolder(subfolder);
        }
    }

    public void Click() {
        folderDialog.Popup_();
        folderDialog.RectPosition = new Vector2(140, 60);
        folderDialog.RectMinSize = new Vector2(1000, 600);
    }
}
