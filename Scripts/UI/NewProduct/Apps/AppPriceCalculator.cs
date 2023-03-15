using Godot;
using System;

public class AppPriceCalculator : Label {
    int facebookOmeter = 0;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Algorithms Pro")
                facebookOmeter += 1;
            if (item.Name == "Algorithms Pro Max")
                facebookOmeter += 1;
            if (item.Name == "Algorithms Pro Max Ultra")
                facebookOmeter += 1;
            if (item.Name == "Algorithms 2")
                facebookOmeter += 1;
            if (item.Name == "Algorithms 2 Pro")
                facebookOmeter += 1;
            if (item.Name == "Algorithms 2 Pro Max")
                facebookOmeter += 1;
            if (item.Name == "Algorithms 2 Pro Max Ultra")
                facebookOmeter += 1;
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

        Text = "This product will cost $" + String.Format("{0:n0}", Global.AppNewProduct.MoneySpent);
        
        base._Process(delta);
    }
}
