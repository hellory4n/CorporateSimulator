using Godot;
using System;

public class EndingRewatch : TextureButton {
    public override void _Ready() {
        if (Global.Achievements.Achievements["Corporate Simulator"] == false)
            QueueFree();
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/EndingVideo.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 421;
        GetTree().Root.AddChild(OK);

        if (GetNodeOrNull("/root/MusicManager") != null) {
            GetNode("/root/MusicManager").QueueFree();
        }
    }
}
