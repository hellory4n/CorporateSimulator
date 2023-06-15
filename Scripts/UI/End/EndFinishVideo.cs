using Godot;
using System;

public class EndFinishVideo : VideoPlayer {
    public override void _Ready() {
        this.Connect("finished", this, nameof(FinishVideo));
    }

    public void FinishVideo() {
        if (GetNodeOrNull<Node2D>("/root/EpicBruhMoment") != null)
            GetNode<Node2D>("/root/EpicBruhMoment").QueueFree();

        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/GameFinished2.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);

        if (Global.Settings.Music) {
            var yesm = (PackedScene)ResourceLoader.Load("res://Scenes/MusicManager.tscn");
            AudioStreamPlayer OKm = (AudioStreamPlayer)yesm.Instance();
            GetTree().Root.AddChild(OKm);
        }

        GetParent().QueueFree();
    }
}
