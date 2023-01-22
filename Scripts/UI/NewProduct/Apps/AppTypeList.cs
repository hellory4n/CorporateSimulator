using Godot;
using System;

public class AppTypeList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/AppTypeButton.tscn");
        
        var OK = (AppTypeButton)yes.Instance();
        OK.Init("Social media");
        AddChild(OK);

        OK = (AppTypeButton)yes.Instance();
        OK.Init("Shopping");
        AddChild(OK);

        OK = (AppTypeButton)yes.Instance();
        OK.Init("Streaming");
        AddChild(OK);

        OK = (AppTypeButton)yes.Instance();
        OK.Init("Video sharing");
        AddChild(OK);

        OK = (AppTypeButton)yes.Instance();
        OK.Init("Gaming");
        AddChild(OK);

        OK = (AppTypeButton)yes.Instance();
        OK.Init("Art");
        AddChild(OK);

        OK = (AppTypeButton)yes.Instance();
        OK.Init("Finance");
        AddChild(OK);

        OK = (AppTypeButton)yes.Instance();
        OK.Init("Dating");
        AddChild(OK);

        base._Ready();
    }
}
