using Godot;
using System;

public class MedicalPriceCalculator : Label {
    bool qualityControl = false;

    public override void _Ready() {
        // Contains() decided to workn't
        foreach (var research in Global.Researched) {
            switch (research.Name) {
                case "Quality control":
                    qualityControl = true;
                    break;
            }
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.MedicalNewProduct.Safety = (int)GetNode<HSlider>("../Slider1").Value;
        Global.MedicalNewProduct.Efficacy = (int)GetNode<HSlider>("../Slider2").Value;
        Global.MedicalNewProduct.Reliability = (int)GetNode<HSlider>("../Slider3").Value;
        // jsnhrsnhmfkgyjhmgk
        Global.MedicalNewProduct.Rating = (int)Global.MedicalNewProduct.Efficacy/20 + 
            (int)Global.MedicalNewProduct.Safety/40 + (int)Global.MedicalNewProduct.Reliability/40;
        Global.MedicalNewProduct.Rating++;
        Global.MedicalNewProduct.MoneySpent = Global.MedicalNewProduct.Safety*200 +
            Global.MedicalNewProduct.Efficacy*200 + Global.MedicalNewProduct.Reliability*200;

        if (qualityControl) {
            Global.MedicalNewProduct.MoneySpent += 20000;
            Global.MedicalNewProduct.Reliability += 50;
        }

        if (Global.Investors/50 > 1)
            Global.MedicalNewProduct.MoneySpent *= ((long)Global.Investors/50);

        Text = "This product will cost $" + String.Format("{0:n0}", Global.MedicalNewProduct.MoneySpent) + " to develop";
        base._Process(delta);
    }
}
