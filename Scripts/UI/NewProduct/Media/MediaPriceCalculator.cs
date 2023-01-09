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
            this.Text = "This product will cost $20,000 to develop";
            Global.MediaNewProduct.MoneySpent = 20000;
        } else {
            this.Text = "This product will cost $1,000 to develop";
            Global.MediaNewProduct.MoneySpent = 1000;
        }
        base._Process(delta);
    }
}
