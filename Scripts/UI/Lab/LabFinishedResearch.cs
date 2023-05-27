using Godot;
using System;

public class LabFinishedResearch : Label {
    public override void _Ready() {
        Text = $"Our lab has successfully researched {Global.LabResearch[Global.LabResearch.Count-1]}";
        base._Ready();
    }
}
