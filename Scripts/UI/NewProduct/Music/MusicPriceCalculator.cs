using Godot;
using System;

public class MusicPriceCalculator : Label {
    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Cooler Music")
                Global.MusicNewProduct.Rating += 1;
            if (item.Name == "4D Music")
                Global.MusicNewProduct.Rating += 1;
            if (item.Name == "Interdimensional Music")
                Global.MusicNewProduct.Rating += 1;
            if (item.Name == "Universe-breaking Music")
                Global.MusicNewProduct.Rating += 1;
            if (item.Name == "Music that makes new multiverses")
                Global.MusicNewProduct.Rating += 1;
            if (item.Name == "NOISES II")
                Global.MusicNewProduct.Rating += 1;
        }
        base._Ready();
    }

    public override void _Process(float delta) {
        Global.MusicNewProduct.Speed = (int)GetNode<HSlider>("../Slider1").Value;
        Global.MusicNewProduct.Melody = (int)GetNode<HSlider>("../Slider2").Value;
        Global.MusicNewProduct.Instruments = (int)GetNode<HSlider>("../Slider3").Value;
        Global.MusicNewProduct.MoneySpent = (1000 + (Global.MusicNewProduct.Instruments * 10)) * 10;
        Text = "This product will cost $" + String.Format("{0:n0}", Global.MusicNewProduct.MoneySpent);

        if (Global.MusicNewProduct.Rating > 10)
            Global.MusicNewProduct.Rating = 10;

        base._Process(delta);
    }
}
