using Godot;
using System;

public class InstallMod : TextureButton {
    private FileDialog folderDialog;

    public override void _Ready() {
        CanvasLayer coolThingy = new CanvasLayer();
        coolThingy.Layer = 128;
        folderDialog = new FileDialog();
        folderDialog.Mode = FileDialog.ModeEnum.OpenDir;
        folderDialog.Access = FileDialog.AccessEnum.Filesystem;

        if (OS.GetName() == "Android")
            folderDialog.CurrentDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        else
            folderDialog.CurrentDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);

        folderDialog.Connect("dir_selected", this, nameof(OnFolderSelected));
        AddChild(coolThingy);
        coolThingy.AddChild(folderDialog);
        this.Connect("pressed", this, nameof(Click));
    }

    public void OnFolderSelected(string dir) {
        string folderPath = dir;
        string destinationPath = $"user://mods/{System.IO.Path.GetFileName(folderPath)}/";
        
        string[] files = System.IO.Directory.GetFiles(folderPath);
        foreach (string file in files) {
            string fileName = System.IO.Path.GetFileName(file);
            string destinationFile = System.IO.Path.Combine(destinationPath, fileName);
            
            var newMod = new File();
            newMod.Open(file, File.ModeFlags.Read);
            
            var jhjk = new File();
            jhjk.Open(destinationFile, File.ModeFlags.Write);
            jhjk.StoreBuffer(newMod.GetBuffer((int)newMod.GetLen()));
            jhjk.Close();
            
            newMod.Close();
        }
        
        GD.Print("successfully installed mod");
    }

    public void Click() {
        folderDialog.Popup_();
        folderDialog.RectPosition = new Vector2(140, 60);
        folderDialog.RectMinSize = new Vector2(1000, 600);
        GD.Print("hi buttonpress");
    }
}
