using Godot;
using System;

public class FoodPriceCalculator : Label {
    bool hasMagic = false;

    public override void _Ready() {
        // Contains() decided to workn't
        foreach (var research in Global.Researched) {
            switch (research.Name) {
                case "Magic":
                    hasMagic = true;
                    break;
            }
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.FoodNewProduct.NutritionalValue = (int)GetNode<HSlider>("../Slider1").Value;
        Global.FoodNewProduct.Taste = (int)GetNode<HSlider>("../Slider2").Value;
        Global.FoodNewProduct.Rating = (int)Global.FoodNewProduct.Taste/10;
        Global.FoodNewProduct.MoneySpent = Global.FoodNewProduct.NutritionalValue*200 +
            Global.FoodNewProduct.Taste*100;

        if (hasMagic) {
            Global.FoodNewProduct.MoneySpent += 20000;
            Global.FoodNewProduct.Taste += 50;
            Global.FoodNewProduct.Rating += 2;
        }
        if (Global.FoodNewProduct.Taste > 100)
            Global.FoodNewProduct.Taste = 100;
        if (Global.FoodNewProduct.Rating > 10)
            Global.FoodNewProduct.Rating = 10;

        Text = "This product will cost $" + String.Format("{0:n0}", Global.FoodNewProduct.MoneySpent);
        base._Process(delta);
    }
}
