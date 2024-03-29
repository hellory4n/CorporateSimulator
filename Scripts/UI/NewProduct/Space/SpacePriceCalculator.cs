using Godot;
using System;

public class SpacePriceCalculator : Label {
    public override void _Process(float delta) {
        // Contains() decided to workn't
        foreach (var research in Global.Researched) {
            switch (research.Name) {
                case "Rocket booster V1":
                    Global.SpaceNewProduct.RocketBoost = 1;
                    break;
                case "Rocket booster V2":
                    Global.SpaceNewProduct.RocketBoost = 2;
                    break;
                case "Rocket booster V3":
                    Global.SpaceNewProduct.RocketBoost = 3;
                    break;
            }
        }

        if (Global.SpaceNewProduct.RocketBoost > 0)
            Global.SpaceNewProduct.Speed = (int)GetNode<HSlider>("../Slider1").Value *
                (Global.SpaceNewProduct.RocketBoost*10);
        else
            Global.SpaceNewProduct.Speed = (int)GetNode<HSlider>("../Slider1").Value;

        Global.SpaceNewProduct.Fuel = (int)GetNode<HSlider>("../Slider2").Value;
        Global.SpaceNewProduct.Safety = (int)GetNode<HSlider>("../Slider3").Value;
        Global.SpaceNewProduct.MoneySpent = Global.SpaceNewProduct.Speed * 50 + Global.SpaceNewProduct.Fuel
            + Global.SpaceNewProduct.Safety * 50 + Global.SpaceNewProduct.People * 1000 +
            Global.SpaceNewProduct.RocketBoost * 250;
        switch (Global.SpaceNewProduct.Carrying) {
            case "Animals": Global.SpaceNewProduct.MoneySpent += 500; break;
            case "People": Global.SpaceNewProduct.MoneySpent += 5000; break;
            case "Space station": Global.SpaceNewProduct.MoneySpent += 20000; break;
            case "Terraforming stuff": Global.SpaceNewProduct.MoneySpent += 1000000; break;
            case "Colonizer 5000": Global.SpaceNewProduct.MoneySpent += 500000; break;
            case "SpaceFarmer 10K": Global.SpaceNewProduct.MoneySpent += 5000000; break;
            case "Ultra Planet Exploiter & Mining 69,000": Global.SpaceNewProduct.MoneySpent += 10000000; break;
            case "Environmental Issues Inc. Space Edition": Global.SpaceNewProduct.MoneySpent += 50000000; break;
        }
        switch (Global.SpaceNewProduct.Destination) {
            case "Earth's orbit": Global.SpaceNewProduct.MoneySpent += 5000; break;
            case "Moon": Global.SpaceNewProduct.MoneySpent += 20000; break;
            case "Venus": Global.SpaceNewProduct.MoneySpent += 40000; break;
            case "Mercury": Global.SpaceNewProduct.MoneySpent += 75000; break;
            case "Mars": Global.SpaceNewProduct.MoneySpent += 50000; break;
            case "Jupiter": Global.SpaceNewProduct.MoneySpent += 75000; break;
            case "Saturn": Global.SpaceNewProduct.MoneySpent += 100000; break;
            case "Uranus": Global.SpaceNewProduct.MoneySpent += 125000; break;
            case "Neptune": Global.SpaceNewProduct.MoneySpent += 150000; break;
        }
        Text = "This product will cost $" + String.Format("{0:n0}", Global.SpaceNewProduct.MoneySpent);
        base._Process(delta);
    }
}