using Godot;
using System;

public class MediaGenre : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/MediaGenreButton.tscn");
        
        var OK = (MediaGenreButton)yes.Instance();
        OK.Init("Action and adventure");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Classics");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Animation");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Detective and mystery");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Fantasy");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Historical fiction");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Horror");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Literary fiction");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Romance");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Science fiction");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Short");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Suspense and thrillers");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Biographies");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Comedy");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Documentary");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("History");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Memoir");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Poetry");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("Self-help");
        AddChild(OK);

        OK = (MediaGenreButton)yes.Instance();
        OK.Init("True crime");
        AddChild(OK);

        base._Ready();
    }
}
