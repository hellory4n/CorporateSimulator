using Godot;
using System;

public class SpacePriceCalculator : Label {
    public override void _Process(float delta) {
        Global.SpaceNewProduct.Speed = (int)GetNode<HSlider>("../Slider1").Value;
        Global.SpaceNewProduct.Fuel = (int)GetNode<HSlider>("../Slider2").Value;
        Global.SpaceNewProduct.Safety = (int)GetNode<HSlider>("../Slider3").Value;
        Global.SpaceNewProduct.MoneySpent = Global.SpaceNewProduct.Speed * 50 + Global.SpaceNewProduct.Fuel
            + Global.SpaceNewProduct.Safety * 50 + Global.SpaceNewProduct.People * 1000 +
            Global.SpaceNewProduct.RocketBoost * 250;
        switch (Global.SpaceNewProduct.Carrying) {
            case "Animals": Global.SpaceNewProduct.MoneySpent += 500; break;
        }
        switch (Global.SpaceNewProduct.Destination) {
            case "Earth's orbit": Global.SpaceNewProduct.MoneySpent += 5000; break;
            case "Moon": Global.SpaceNewProduct.MoneySpent += 20000; break;
        }
        Text = "This product will cost $" + String.Format("{0:n0}", Global.SpaceNewProduct.MoneySpent);
        base._Process(delta);
    }
}