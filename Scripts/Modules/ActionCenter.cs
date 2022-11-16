using Godot;
using System;

public class ActionCenter : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (GetNodeOrNull("/root/ActionCenter") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/ActionCenter.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
        } else
            GetNode("/root/ActionCenter").QueueFree();
    }
}
