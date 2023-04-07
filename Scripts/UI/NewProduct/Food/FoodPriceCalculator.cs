using Godot;
using System;

public class FoodPriceCalculator : Label {
    bool highQualityIngredients = false;
    bool peakFoodSafety = false;

    public override void _Ready() {
        // Contains() decided to workn't
        foreach (var research in Global.Researched) {
            switch (research.Name) {
                case "High quality ingredients":
                    highQualityIngredients = true;
                    break;
                case "Peak food safety":
                    peakFoodSafety = true;
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

        if (highQualityIngredients) {
            Global.FoodNewProduct.MoneySpent += 20000;
            Global.FoodNewProduct.Rating += 1;
        }
        if (peakFoodSafety) {
            Global.FoodNewProduct.MoneySpent += 10000;
            Global.FoodNewProduct.Rating += 1;
        }
        if (Global.FoodNewProduct.Rating > 10)
            Global.FoodNewProduct.Rating = 10;
        
        if (Global.Investors/50 > 1)
            Global.FoodNewProduct.MoneySpent *= ((int)Global.Investors/50);

        Text = "This product will cost $" + String.Format("{0:n0}", Global.FoodNewProduct.MoneySpent) +
        " to develop";
        base._Process(delta);
    }
}
