using Godot;
using System;

public class LoadGame : TextureButton {
    [Export]
    public string gameFile;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (GetNodeOrNull("/root/Game") != null) {
            Node ben = GetNode("/root/Game");
            ben.QueueFree();
            ben.Name = "jkolskjhgjlkrjjhekol";
        }

        // was this save menu created by the new game dialog?
        if (Global.NewGameSave != null)
            Savior.NewGame(gameFile, Global.NewGameSave);

        PackedScene game = (PackedScene)ResourceLoader.Load("res://Scenes/Level1.tscn");
        Game game_ = (Game)game.Instance();
        game_.Name = "Game";
        game_.Init(gameFile);
        GetTree().Root.AddChild(game_);
        // this button is inside a control node
        GetParent().GetParent().QueueFree();
    }
}
