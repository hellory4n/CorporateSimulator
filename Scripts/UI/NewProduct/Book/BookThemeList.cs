using Godot;
using System;

public class BookThemeList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/BookThemeButton.tscn");
        
        var OK = (BookThemeButton)yes.Instance();
        OK.Init("Circle of life");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Coming of age");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Faith VS doubt");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Family");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Fate VS free will");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Good VS evil");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Hubris");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Identity");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Justice");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Loneliness");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Man VS nature");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Man VS self");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Man VS society");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Power and corruption");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Pursuit of love");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Revenge");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Sacrificial love");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("Survival");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("The environment");
        AddChild(OK);

        OK = (BookThemeButton)yes.Instance();
        OK.Init("War");
        AddChild(OK);

        base._Ready();
    }
}
