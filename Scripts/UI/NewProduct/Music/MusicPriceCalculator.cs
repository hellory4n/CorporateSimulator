using Godot;
using System;

public class MusicPriceCalculator : Label {
    public override void _Process(float delta) {
        Global.MusicNewProduct.Speed = (int)GetNode<HSlider>("../Slider1").Value;
        Global.MusicNewProduct.Melody = (int)GetNode<HSlider>("../Slider2").Value;
        Global.MusicNewProduct.Instruments = (int)GetNode<HSlider>("../Slider3").Value;
        Global.MusicNewProduct.MoneySpent = 1000 + (Global.MusicNewProduct.Instruments * 10);
        Text = "This product will cost $" + String.Format("{0:n0}", Global.MusicNewProduct.MoneySpent);
        base._Process(delta);
    }
}
