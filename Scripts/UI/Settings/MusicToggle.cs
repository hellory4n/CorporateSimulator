using Godot;
using System;

public class MusicToggle : TextureButton {
    Label text;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        text = GetNode<Label>("Label");
        // if the game starts with musics disabled it's still gonna say "Music: ON"
        if (!Global.Settings.Music)
            text.Text = "Music: OFF";
    }

    public void Click() {
        if (GetNodeOrNull("/root/MusicManager") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/MusicManager.tscn");
            AudioStreamPlayer OK = (AudioStreamPlayer)yes.Instance();
            GetTree().Root.AddChild(OK);
            text.Text = "Music: ON";
        } else {
            GetNode("/root/MusicManager").QueueFree();
            text.Text = "Music: OFF";
        }

        Global.Settings.Music = !Global.Settings.Music;
        Savior.SaveSettings(Global.Settings);
    }
}
