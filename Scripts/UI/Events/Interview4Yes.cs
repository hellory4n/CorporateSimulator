using Godot;
using System;

public class Interview4Yes : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Reputation -= 1;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Interview5.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
