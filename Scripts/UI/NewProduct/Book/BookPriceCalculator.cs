using Godot;
using System;

public class BookPriceCalculator : Label {
    bool isGiant = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Giant books")
                isGiant = true;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        if (isGiant) {
            Global.BookNewProduct.MoneySpent = 5000;
        } else {
            Global.BookNewProduct.MoneySpent = 1000;
        }

        if (Global.Investors/10 > 1)
            Global.BookNewProduct.MoneySpent *= ((int)Global.Investors/10);

        this.Text = $"This book will cost ${String.Format("{0:n0}", Global.BookNewProduct.MoneySpent)} to develop";

        base._Process(delta);
    }
}
