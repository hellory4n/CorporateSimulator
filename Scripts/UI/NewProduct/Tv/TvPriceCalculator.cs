using Godot;
using System;

public class TvPriceCalculator : Label {
    bool ben = false;
    int youTubeOmeter = 1;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "4K")
                ben = true;
            if (item.Name == "Ads Pro")
                youTubeOmeter += 1;
            if (item.Name == "Ads Pro Max")
                youTubeOmeter += 1;
            if (item.Name == "Ads Pro Max Ultra")
                youTubeOmeter += 1;
            if (item.Name == "Ads 2")
                youTubeOmeter += 1;
            if (item.Name == "Ads 2 Pro")
                youTubeOmeter += 1;
            if (item.Name == "Ads 2 Pro Max")
                youTubeOmeter += 1;
            if (item.Name == "Ads 2 Pro Max Ultra")
                youTubeOmeter += 1;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.TvNewProduct.ProductionTime = (int)GetNode<HSlider>("../Slider1").Value;
        Global.TvNewProduct.Script = (int)GetNode<HSlider>("../Slider2").Value;
        Global.TvNewProduct.Ads = (int)GetNode<HSlider>("../Slider3").Value * youTubeOmeter;
        Global.TvNewProduct.Rating = (int)Global.TvNewProduct.ProductionTime/20 +
            (int)Global.TvNewProduct.Script/20;
        Global.TvNewProduct.MoneySpent = Global.TvNewProduct.ProductionTime*100 +
            Global.TvNewProduct.Script*100;
        
        if (ben)
            Global.TvNewProduct.MoneySpent += 10000;
        
        if (Global.Investors/50 > 1)
            Global.TvNewProduct.MoneySpent *= ((int)Global.Investors/50);

        Text = "This product will cost $" + String.Format("{0:n0}", Global.TvNewProduct.MoneySpent);
        
        base._Process(delta);
    }
}
