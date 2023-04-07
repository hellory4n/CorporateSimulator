using Godot;
using System;

public class BookPriceCalculator : Label {
    bool isGiant = false;
    bool outstandingImprovement = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Bible-sized books")
                isGiant = true;
            if (item.Name == "A different font")
                outstandingImprovement = true;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        if (isGiant) {
            Global.BookNewProduct.MoneySpent = 5000;
        } else {
            Global.BookNewProduct.MoneySpent = 1000;
        }

        if (outstandingImprovement)
            Global.BookNewProduct.MoneySpent += 10000;

        if (Global.Investors/20 > 1)
            Global.BookNewProduct.MoneySpent *= ((int)Global.Investors/20);

        this.Text = $"This book will cost ${String.Format("{0:n0}", Global.BookNewProduct.MoneySpent)} to develop";

        base._Process(delta);
    }
}
