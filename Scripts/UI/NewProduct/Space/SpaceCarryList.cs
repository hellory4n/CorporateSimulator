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

        // Contains() decided to workn't
        foreach (var research in Global.Researched) {
            switch (research.Name) {
                case "Satellites":
                    OK = (SpaceCarryButton)yes.Instance();
                    OK.Init("Satellites");
                    AddChild(OK);
                    break;
                case "People":
                    OK = (SpaceCarryButton)yes.Instance();
                    OK.Init("People");
                    AddChild(OK);
                    break;
                case "Space station":
                    OK = (SpaceCarryButton)yes.Instance();
                    OK.Init("Space station");
                    AddChild(OK);
                    break;
                case "Terraforming":
                    OK = (SpaceCarryButton)yes.Instance();
                    OK.Init("Terraforming stuff");
                    AddChild(OK);
                    break;
            }
        }

        base._Ready();
    }
}
