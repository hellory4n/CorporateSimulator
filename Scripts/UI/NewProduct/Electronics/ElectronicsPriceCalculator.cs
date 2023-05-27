using Godot;
using System;

public class ElectronicsPriceCalculator : Label {
    bool energyEffiency = false;
    int interdimensionalEncryption = 1;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Energy efficiency")
                energyEffiency = true;
            if (item.Name == "Interdimensional encryption")
                interdimensionalEncryption = 2;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.ElectronicsNewProduct.Features = (int)GetNode<HSlider>("../Slider1").Value;
        Global.ElectronicsNewProduct.Security = (int)GetNode<HSlider>("../Slider2").Value
            * interdimensionalEncryption;
        Global.ElectronicsNewProduct.IoTNess = (int)GetNode<HSlider>("../Slider3").Value;
        Global.ElectronicsNewProduct.Rating = (int)Global.ElectronicsNewProduct.Features/20 +
            (int)Global.ElectronicsNewProduct.IoTNess/20;
        Global.ElectronicsNewProduct.MoneySpent = Global.ElectronicsNewProduct.Features*50 +
            Global.ElectronicsNewProduct.Security * 50 + Global.ElectronicsNewProduct.IoTNess*50;

        if (energyEffiency)
            Global.ElectronicsNewProduct.Rating += 1;

        if (Global.ElectronicsNewProduct.Rating > 10)
            Global.ElectronicsNewProduct.Rating = 10;

        if (Global.Investors/100 > 1)
            Global.ElectronicsNewProduct.MoneySpent *= ((long)Global.Investors/100);

        Text = "This product will cost $" + String.Format("{0:n0}", Global.ElectronicsNewProduct.MoneySpent)
        + " to develop";
        
        

        base._Process(delta);
    }
}
