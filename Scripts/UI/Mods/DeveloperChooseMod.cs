using Godot;
using System;

public class DeveloperChooseMod : TextureButton
{
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
        Global.DeveloperMod = epicCoolMod;
    }

    public void Click() {
        folderDialog.Popup_();
        folderDialog.RectPosition = new Vector2(140, 60);
        folderDialog.RectMinSize = new Vector2(1000, 600);
    }
}
