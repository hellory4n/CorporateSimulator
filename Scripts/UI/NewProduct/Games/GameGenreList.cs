using Godot;
using System;

public class GameGenreList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/GameGenreButton.tscn");
        
        var OK = (GameGenreButton)yes.Instance();
        OK.Init("Action");
        AddChild(OK);

        OK = (GameGenreButton)yes.Instance();
        OK.Init("Adventure");
        AddChild(OK);

        OK = (GameGenreButton)yes.Instance();
        OK.Init("RPG");
        AddChild(OK);

        OK = (GameGenreButton)yes.Instance();
        OK.Init("Simulation");
        AddChild(OK);

        OK = (GameGenreButton)yes.Instance();
        OK.Init("Strategy");
        AddChild(OK);

        OK = (GameGenreButton)yes.Instance();
        OK.Init("Casual");
        AddChild(OK);

        base._Ready();
    }
}
