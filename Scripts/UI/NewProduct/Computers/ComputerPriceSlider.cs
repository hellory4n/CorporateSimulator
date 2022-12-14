using Godot;
using System;

public class ComputerPriceSlider : HSlider {
    public override void _Process(float delta) {
        // so it doesn't infinitely grow
        Global.ComputerNewProduct.Price = 0;

        Global.ComputerNewProduct.Price += int.Parse(Global.ComputerNewProduct.Cpu.Split(",")[3]);
        Global.ComputerNewProduct.Price += int.Parse(Global.ComputerNewProduct.Gpu.Split(",")[3]);
        Global.ComputerNewProduct.Price += int.Parse(Global.ComputerNewProduct.Ram.Split(",")[1]);
        Global.ComputerNewProduct.Price += int.Parse(Global.ComputerNewProduct.Storage.Split(",")[3]);
        Global.ComputerNewProduct.Price += int.Parse(Global.ComputerNewProduct.Os.Split(",")[3]);
        Global.ComputerNewProduct.Price += (int)Value;

        GetNode<Label>("Label").Text = "Price - $" + String.Format("{0:n0}", Global.ComputerNewProduct.Price);;

        base._Process(delta);
    }
}
