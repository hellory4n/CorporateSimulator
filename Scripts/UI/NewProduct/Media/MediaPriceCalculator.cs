using Godot;
using System;

public class MediaPriceCalculator : Label {
    bool ben = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Famous actors")
                ben = true;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        if (ben) {
            Global.MediaNewProduct.MoneySpent = 25000;
        } else {
            Global.MediaNewProduct.MoneySpent = 5000;
        }

        if (Global.Investors/50 > 1)
            Global.MediaNewProduct.MoneySpent *= ((long)Global.Investors/50);

        this.Text = $"This product will cost ${String.Format("{0:n0}", Global.MediaNewProduct.MoneySpent)} to develop";
        base._Process(delta);
    }
}
