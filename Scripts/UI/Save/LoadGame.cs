using Godot;
using System;

public class LoadGame : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        PackedScene game = (PackedScene)ResourceLoader.Load("res://Scenes/Level1.tscn");
        Node2D game_ = (Node2D)game.Instance();
        game_.Name = "Game";
        GetTree().Root.AddChild(game_);
        // this button is inside a control node
        GetParent().GetParent().QueueFree();
    }
}
