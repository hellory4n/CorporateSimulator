using Godot;
using System;

public class LabBudget : HSlider {
    public override void _Ready() {
        Value = Global.LabBudget;
        base._Ready();
    }

    public override void _Process(float delta) {
        GetNode<Label>("./Label").Text = "Budget: $" + String.Format("{0:n0}", Value);
        Global.LabBudget = (int)Value;
        base._Process(delta);
    }
}
