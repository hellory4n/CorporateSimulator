using Godot;
using System;

public class FullscreenToggle : TextureButton {
    Label text;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        text = GetNode<Label>("Label");
        // i just stealed this whole script from the autosave toggle which is stolen from the music toggle
        if (!Global.Settings.Fullscreen)
            text.Text = "Fullscreen: OFF";
    }

    public void Click() {
        Global.Settings.Fullscreen = !Global.Settings.Fullscreen;
        Savior.SaveSettings(Global.Settings);

        if (Global.Settings.Fullscreen)
            text.Text = "Fullscreen: ON";
        else
            text.Text = "Fullscreen: OFF";
    }
}
