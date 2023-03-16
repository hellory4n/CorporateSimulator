using Godot;
using System;

public class PhonePrice : HSlider {
    bool gimmicks = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Gimmicks")
                gimmicks = true;
        }
    }

    public override void _Process(float delta) {
        // so it doesn't infinitely grow
        Global.PhoneNewProduct.Price = 0;

        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Soc.Split(",")[3]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Size.Split(",")[2]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Ram.Split(",")[1]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Storage.Split(",")[2]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Battery.Split(",")[2]);
        Global.PhoneNewProduct.Price += (int)Value;

        if (gimmicks)
            Global.PhoneNewProduct.Price += 300;

        GetNode<Label>("Label").Text = "Price - $" + String.Format("{0:n0}", Global.PhoneNewProduct.Price);;

        base._Process(delta);
    }
}
