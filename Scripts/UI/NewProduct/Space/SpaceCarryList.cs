using Godot;
using System;

public class SpaceCarryList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/SpaceCarryButton.tscn");
        
        var OK = (SpaceCarryButton)yes.Instance();
        OK.Init("Nothing");
        AddChild(OK);

        OK = (SpaceCarryButton)yes.Instance();
        OK.Init("Animals");
        AddChild(OK);

        base._Ready();
    }
}
