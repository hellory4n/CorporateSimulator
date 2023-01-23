using Godot;
using System;

public class MarketingSlider : HSlider {
    public override void _Process(float delta) {
        if (Value != 0)
            GetNode<Label>("Label").Text = "Budget: $" + Value + ",000";
        else
            GetNode<Label>("Label").Text = "Budget: $" + Value;
        
        Global.MarketingBudget = (int)Value*1000;
        base._Process(delta);
    }
}
