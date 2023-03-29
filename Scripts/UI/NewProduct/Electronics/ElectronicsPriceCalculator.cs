using Godot;
using System;

public class ElectronicsPriceCalculator : Label {
    int sillyOmeter = 1;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "IoT Pro")
                sillyOmeter += 1;
            if (item.Name == "IoT Pro Max")
                sillyOmeter += 1;
            if (item.Name == "IoT Pro Max Ultra")
                sillyOmeter += 1;
            if (item.Name == "IoT 2")
                sillyOmeter += 1;
            if (item.Name == "IoT 2 Pro")
                sillyOmeter += 1;
            if (item.Name == "IoT 2 Pro Max")
                sillyOmeter += 1;
            if (item.Name == "IoT 2 Pro Max Ultra")
                sillyOmeter += 1;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.ElectronicsNewProduct.Features = (int)GetNode<HSlider>("../Slider1").Value;
        Global.ElectronicsNewProduct.Security = (int)GetNode<HSlider>("../Slider2").Value;
        Global.ElectronicsNewProduct.IoTNess = (int)GetNode<HSlider>("../Slider3").Value * sillyOmeter;
        Global.ElectronicsNewProduct.Rating = (int)Global.ElectronicsNewProduct.Features/20 +
            (int)Global.ElectronicsNewProduct.IoTNess/20;
        Global.ElectronicsNewProduct.MoneySpent = Global.ElectronicsNewProduct.Features*50 +
            Global.ElectronicsNewProduct.Security * 50 + Global.ElectronicsNewProduct.IoTNess*50;

        if (Global.Investors/100 > 1)
            Global.ElectronicsNewProduct.MoneySpent *= ((int)Global.Investors/100);

        Text = "This product will cost $" + String.Format("{0:n0}", Global.ElectronicsNewProduct.MoneySpent)
        + " to develop";
        
        if (Global.ElectronicsNewProduct.Rating > 10)
            Global.ElectronicsNewProduct.Rating = 10;

        base._Process(delta);
    }
}
