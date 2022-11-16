using Godot;
using System;

public class SpaceFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.SpaceNewProduct.Speed = (int)GetNode<HSlider>("../Slider1").Value;
        Global.SpaceNewProduct.Fuel = (int)GetNode<HSlider>("../Slider2").Value;
        Global.SpaceNewProduct.Safety = (int)GetNode<HSlider>("../Slider3").Value;
        GetParent().QueueFree();
    }
}
