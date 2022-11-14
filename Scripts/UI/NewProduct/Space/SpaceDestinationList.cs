using Godot;
using System;

public class SpaceDestinationList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/SpaceDestinationButton.tscn");
        
        var OK = (SpaceDestinationButton)yes.Instance();
        OK.Init("Earth's orbit");
        AddChild(OK);

        OK = (SpaceDestinationButton)yes.Instance();
        OK.Init("Moon");
        AddChild(OK);

        base._Ready();
    }
}
