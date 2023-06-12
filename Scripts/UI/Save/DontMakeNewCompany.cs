using Godot;
using System;

public class DontMakeNewCompany : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        // if you click cancel on the make new company dialog without loading any save before it'll just die
        if (GetNodeOrNull<Node>("/root/Game") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Saves.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
        }
        GetParent().QueueFree();
    }
}
