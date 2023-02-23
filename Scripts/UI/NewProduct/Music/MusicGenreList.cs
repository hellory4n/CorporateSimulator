using Godot;
using System;

public class MusicGenreList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/MusicGenreButton.tscn");
        
        var OK = (MusicGenreButton)yes.Instance();
        OK.Init("Blues");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Country");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Easy listening");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Electronic");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Contemporary folk");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Hip hop");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Jazz");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Pop");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("R&B and soul");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Rock");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Metal");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Punk");
        AddChild(OK);

        OK = (MusicGenreButton)yes.Instance();
        OK.Init("Something else");
        AddChild(OK);
        base._Ready();
    }
}
