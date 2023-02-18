using Godot;
using System;

public class Interview3Yes : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Reputation -= 5;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Interview4.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
