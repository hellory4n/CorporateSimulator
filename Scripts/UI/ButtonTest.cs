using Godot;
using System;

public class ButtonTest : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GD.Print("hi");
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/GodotSpriteToTestTheButton.tscn");
        Node2D OK = (Node2D)yes.Instance();
        GetTree().Root.AddChild(OK);
    }
}
