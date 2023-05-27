using Godot;
using System;

public class LabProgress : Label {
    public override void _Process(float delta) {
        if (Global.LabCurrentProject == "nothing") {
            Text = "The lab is currently doing nothing.";
        } else {
            double coolPercentage = ((Global.LabTotalCost - Global.LabThingsToSpend) / Global.LabTotalCost) * 100;
            GD.Print(coolPercentage);
            Text = $"Researching {Global.LabCurrentProject}: {coolPercentage}%";
        }
        base._Process(delta);
    }
}
