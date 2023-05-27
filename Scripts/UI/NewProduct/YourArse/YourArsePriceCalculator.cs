using Godot;
using System;

public class YourArsePriceCalculator : Label {
    int sponsorships = 1;
    bool epicEditing = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Epic editing")
                epicEditing = true;
            if (item.Name == "Sponsorships")
                sponsorships = 2;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.YourArseNewProduct.ProductionTime = (int)GetNode<HSlider>("../Slider1").Value;
        Global.YourArseNewProduct.Script = (int)GetNode<HSlider>("../Slider2").Value;
        Global.YourArseNewProduct.Ads = (int)GetNode<HSlider>("../Slider3").Value * sponsorships;
        Global.YourArseNewProduct.Rating = (int)Global.YourArseNewProduct.ProductionTime/20 +
            (int)Global.YourArseNewProduct.Script/20;
        Global.YourArseNewProduct.MoneySpent = Global.YourArseNewProduct.ProductionTime*100 +
            Global.YourArseNewProduct.Script*100;

        if (epicEditing)
            Global.YourArseNewProduct.MoneySpent += 10000;
            Global.YourArseNewProduct.Rating += 1;

        if (Global.YourArseNewProduct.Rating > 10)
            Global.YourArseNewProduct.Rating = 10;

        if (Global.Investors/75 > 1)
            Global.YourArseNewProduct.MoneySpent *= ((long)Global.Investors/75);

        Text = "This product will cost $" + String.Format("{0:n0}", Global.YourArseNewProduct.MoneySpent);

        base._Process(delta);
    }
}
