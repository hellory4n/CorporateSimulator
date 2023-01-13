using Godot;
using System;

public class PhonePrice : HSlider {
    public override void _Process(float delta) {
        // so it doesn't infinitely grow
        Global.PhoneNewProduct.Price = 0;

        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Soc.Split(",")[3]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Size.Split(",")[2]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Ram.Split(",")[1]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Storage.Split(",")[2]);
        Global.PhoneNewProduct.Price += int.Parse(Global.PhoneNewProduct.Battery.Split(",")[2]);
        Global.PhoneNewProduct.Price += (int)Value;

        GetNode<Label>("Label").Text = "Price - $" + String.Format("{0:n0}", Global.PhoneNewProduct.Price);;

        base._Process(delta);
    }
}
