using Godot;
using System;

public class PhonePrice : HSlider {
    bool nextLevelNotch = false;
    bool cookieDisc = false;
    bool smartphone2 = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Next-level notch")
                nextLevelNotch = true;
            if (item.Name == "CookieDisc")
                cookieDisc = true;
            if (item.Name == "Smartphone 2")
                smartphone2 = true;
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

        if (nextLevelNotch)
            Global.PhoneNewProduct.Price += 10;

        if (cookieDisc)
            Global.PhoneNewProduct.Price += 100;
        
        if (smartphone2)
            Global.PhoneNewProduct.Price += 200;

        Global.PhoneNewProduct.MoneySpent = Global.PhoneNewProduct.Price * 5;

        if (Global.Investors/50 > 1)
            Global.PhoneNewProduct.MoneySpent *= ((int)Global.Investors/50);

        GetNode<Label>("Label").Text = $"Price: ${String.Format("{0:n0}", Global.PhoneNewProduct.Price)} - "
        + $"Development: ${String.Format("{0:n0}", Global.PhoneNewProduct.MoneySpent)}";

        base._Process(delta);
    }
}
