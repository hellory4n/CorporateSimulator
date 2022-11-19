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

        if (!Global.UnlockedResearch.Contains(new ResearchSave("Satellites", 50))) {
            OK = (SpaceCarryButton)yes.Instance();
            OK.Init("Satellites");
            AddChild(OK);
        }

        if (!Global.UnlockedResearch.Contains(new ResearchSave("People", 100))) {
            OK = (SpaceCarryButton)yes.Instance();
            OK.Init("People");
            AddChild(OK);
        }

        if (!Global.UnlockedResearch.Contains(new ResearchSave("Space station", 250))) {
            OK = (SpaceCarryButton)yes.Instance();
            OK.Init("Space station");
            AddChild(OK);
        }

        if (!Global.UnlockedResearch.Contains(new ResearchSave("Terraforming", 5000))) {
            OK = (SpaceCarryButton)yes.Instance();
            OK.Init("Terraforming stuff");
            AddChild(OK);
        }

        base._Ready();
    }
}
