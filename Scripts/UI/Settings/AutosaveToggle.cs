using Godot;
using System;

public class AutosaveToggle : TextureButton {
    Label text;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        text = GetNode<Label>("Label");
        // i just stealed this whole script from the music toggle
        if (!Global.Settings.Autosave)
            text.Text = "Autosave: OFF";
    }

    public void Click() {
        if (GetNodeOrNull("/root/Autosave") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Autosave.tscn");
            Timer OK = (Timer)yes.Instance();
            GetTree().Root.AddChild(OK);
            text.Text = "Autosave: ON";
        } else {
            GetNode("/root/Autosave").QueueFree();
            text.Text = "Autosave: OFF";
        }

        Global.Settings.Autosave = !Global.Settings.Autosave;
        Savior.SaveSettings(Global.Settings);
    }
}
