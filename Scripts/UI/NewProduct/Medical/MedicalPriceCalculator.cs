using Godot;
using System;

public class MedicalPriceCalculator : Label {
    public override void _Ready() {
        // Contains() decided to workn't
        foreach (var research in Global.Researched) {
            switch (research.Name) {
                case "Magic":
                    Global.MedicalNewProduct.Accuracy += 50;
                    Global.MedicalNewProduct.MoneySpent += 20000;
                    if (Global.MedicalNewProduct.Rating < 9)
                        Global.MedicalNewProduct.Rating += 2;
                    break;
            }
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.MedicalNewProduct.Accuracy = (int)GetNode<HSlider>("../Slider1").Value;
        Global.MedicalNewProduct.Marketing = (int)GetNode<HSlider>("../Slider2").Value;
        Global.MedicalNewProduct.Rating = (int)Global.MedicalNewProduct.Accuracy/10;
        Global.MedicalNewProduct.MoneySpent = Global.MedicalNewProduct.Marketing*2 +
            Global.MedicalNewProduct.Accuracy*200;

        Text = "This product will cost $" + String.Format("{0:n0}", Global.MedicalNewProduct.MoneySpent);
        base._Process(delta);
    }
}
