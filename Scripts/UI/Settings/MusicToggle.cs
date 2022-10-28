using Godot;
using System;

public class MusicToggle : TextureButton {
    Label text;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        text = GetNode<Label>("Label");
    }

    public void Click() {
        if (GetNodeOrNull("/root/MusicManager") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/MusicManager.tscn");
            Node2D OK = (Node2D)yes.Instance();
            GetTree().Root.AddChild(OK);
            text.Text = "Music: ON";
        } else {
            GetNode("/root/MusicManager").QueueFree();
            text.Text = "Music: OFF";
        }
    }
}
