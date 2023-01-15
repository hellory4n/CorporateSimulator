using Godot;
using System;

public class YourArsePriceCalculator : Label {
    bool ben = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "4K")
                ben = true;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.YourArseNewProduct.ProductionTime = (int)GetNode<HSlider>("../Slider1").Value;
        Global.YourArseNewProduct.Script = (int)GetNode<HSlider>("../Slider2").Value;
        Global.YourArseNewProduct.Ads = (int)GetNode<HSlider>("../Slider3").Value;
        Global.YourArseNewProduct.Rating = (int)Global.YourArseNewProduct.ProductionTime/20 +
            (int)Global.YourArseNewProduct.Script/20;
        Global.YourArseNewProduct.MoneySpent = Global.YourArseNewProduct.ProductionTime*100 +
            Global.YourArseNewProduct.Script*100;
        
        if (ben)
            Global.YourArseNewProduct.MoneySpent += 10000;

        Text = "This product will cost $" + String.Format("{0:n0}", Global.YourArseNewProduct.MoneySpent);
        
        base._Process(delta);
    }
}
