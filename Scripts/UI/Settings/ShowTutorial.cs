using Godot;
using System;

public class ShowTutorial : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Tutorial.tscn");
        Node2D OK = (Node2D)yes.Instance();
        GetTree().Root.AddChild(OK);
    }
}
