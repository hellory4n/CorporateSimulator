using Godot;
using System;

public class MarketingYes : Label {
    public override void _Ready() {
        if (Global.Products.Count > 0) {
            dynamic garbage = Global.Products[Global.Products.Count-1];
            Text = "Marketing for " + garbage.Name;
        } else
            Text = "You need to make a product to do marketing";
        base._Ready();
    }
}
