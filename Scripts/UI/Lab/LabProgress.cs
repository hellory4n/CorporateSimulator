using Godot;
using System;

public class LabProgress : Label {
    public override void _Ready() {
        if (Global.LabCurrentProject == "nothing") {
            Text = "The lab is currently doing nothing.";
        } else {
            double totalCost = Global.LabTotalCost;
            double thingsToSpend = Global.LabThingsToSpend;
            int coolPercentage = (int)(((totalCost - thingsToSpend) / totalCost) * 100);
            Text = $"Researching {Global.LabCurrentProject}: {coolPercentage}%";
        }
        base._Ready();
    }
}
