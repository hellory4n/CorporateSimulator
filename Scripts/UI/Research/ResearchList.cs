using Godot;
using System;

public class ResearchList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/ResearchButton.tscn");

        foreach (var research in Global.UnlockedResearch) {
            ResearchButton OK = (ResearchButton)yes.Instance();
            OK.Init(research);
            AddChild(OK);
        }
        base._Ready();
    }
}
