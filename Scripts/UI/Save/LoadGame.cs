using Godot;
using System;

public class LoadGame : TextureButton {
    [Export]
    public string gameFile;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        PackedScene game = (PackedScene)ResourceLoader.Load("res://Scenes/Level1.tscn");
        Game game_ = (Game)game.Instance();
        game_.Name = "Game";
        game_.Init(gameFile);
        GetTree().Root.AddChild(game_);
        // this button is inside a control node
        GetParent().GetParent().QueueFree();
    }
}
