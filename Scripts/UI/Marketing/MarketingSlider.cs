using Godot;
using System;

public class MarketingSlider : HSlider {
    public override void _Ready() {
        Value = Global.MarketingBudget;
        if (Global.Money > 10000000)
            MaxValue = 1000;
        if (Global.Money > 50000000)
            MaxValue = 2500;
        base._Ready();
    }

    public override void _Process(float delta) {
        GetNode<Label>("Label").Text = "Budget: $" + String.Format("{0:n0}", Value*1000);        
        Global.MarketingBudget = (int)Value*1000;
        base._Process(delta);
    }
}
