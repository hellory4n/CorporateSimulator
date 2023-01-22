using Godot;
using System;

public class MarketingSlider : HSlider {
    public override void _Process(float delta) {
        if (Value != 0)
            GetNode<Label>("Label").Text = "Budget: $" + Value + ",000";
        else
            GetNode<Label>("Label").Text = "Budget: $" + Value;
        
        
        base._Process(delta);
    }
}
