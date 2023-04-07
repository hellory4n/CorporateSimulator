using Godot;
using System;

public class AppPriceCalculator : Label {
    int facebookOmeter = 1;
    bool epicoPerformance = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Ultimate tracking")
                facebookOmeter += 1;
            if (item.Name == "Better performance")
                epicoPerformance = true;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.AppNewProduct.Algorithm = (int)GetNode<HSlider>("../Slider1").Value * facebookOmeter;
        Global.AppNewProduct.Features = (int)GetNode<HSlider>("../Slider2").Value;
        Global.AppNewProduct.Innovation = (int)GetNode<HSlider>("../Slider3").Value;
        Global.AppNewProduct.Rating = (int)Global.AppNewProduct.Features/20 +
            (int)Global.AppNewProduct.Innovation/20;
        Global.AppNewProduct.MoneySpent = Global.AppNewProduct.Features*100 +
            Global.AppNewProduct.Algorithm * 100 + Global.AppNewProduct.Innovation*100;

        if (epicoPerformance) {
            Global.AppNewProduct.MoneySpent += 10000;
            Global.AppNewProduct.Rating += 1;
        }

        if (Global.AppNewProduct.Rating > 10)
            Global.AppNewProduct.Rating = 10;

        if (Global.Investors/50 > 1)
            Global.AppNewProduct.MoneySpent *= ((int)Global.Investors/50);

        Text = "This product will cost $" + String.Format("{0:n0}", Global.AppNewProduct.MoneySpent)
        + " to develop";
        
        base._Process(delta);
    }
}
