using Godot;
using System;

public class ElectronicsPriceCalculator : Label {
    bool ben = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "IoT V2")
                ben = true;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.ElectronicsNewProduct.Features = (int)GetNode<HSlider>("../Slider1").Value;
        Global.ElectronicsNewProduct.Security = (int)GetNode<HSlider>("../Slider2").Value;
        Global.ElectronicsNewProduct.IoTNess = (int)GetNode<HSlider>("../Slider3").Value;
        Global.ElectronicsNewProduct.Rating = (int)Global.ElectronicsNewProduct.Features/20 +
            (int)Global.ElectronicsNewProduct.IoTNess/20;
        Global.ElectronicsNewProduct.MoneySpent = Global.ElectronicsNewProduct.Features*50 +
            Global.ElectronicsNewProduct.Security * 50 + Global.ElectronicsNewProduct.IoTNess*50;
        
        if (ben)
            Global.ElectronicsNewProduct.MoneySpent += 10000;

        Text = "This product will cost $" + String.Format("{0:n0}", Global.ElectronicsNewProduct.MoneySpent);
        
        base._Process(delta);
    }
}
