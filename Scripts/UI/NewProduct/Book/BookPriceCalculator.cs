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
            this.Text = "This book will cost $5,000 to develop";
            Global.BookNewProduct.MoneySpent = 5000;
        } else {
            this.Text = "This book will cost $1,000 to develop";
            Global.BookNewProduct.MoneySpent = 1000;
        }
        base._Process(delta);
    }
}
