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

        // Contains() decided to workn't
        foreach (var jsjsjjjs in Global.Researched) {
            if (jsjsjjjs.Name == "Go to other planets") {
                OK = (SpaceDestinationButton)yes.Instance();
                OK.Init("Mars");
                AddChild(OK);

                OK = (SpaceDestinationButton)yes.Instance();
                OK.Init("Venus");
                AddChild(OK);

                OK = (SpaceDestinationButton)yes.Instance();
                OK.Init("Mercury");
                AddChild(OK);

                OK = (SpaceDestinationButton)yes.Instance();
                OK.Init("Jupiter");
                AddChild(OK);

                OK = (SpaceDestinationButton)yes.Instance();
                OK.Init("Saturn");
                AddChild(OK);

                OK = (SpaceDestinationButton)yes.Instance();
                OK.Init("Uranus");
                AddChild(OK);

                OK = (SpaceDestinationButton)yes.Instance();
                OK.Init("Neptune");
                AddChild(OK);
            }
        }

        base._Ready();
    }
}
