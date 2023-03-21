using Godot;
using System;

public class GamePrice : Label {
    public override void _Process(float delta) {
        Global.GameNewProduct.Gameplay = (int)GetNode<HSlider>("../Slider1").Value;
        Global.GameNewProduct.Lore = (int)GetNode<HSlider>("../Slider2").Value;
        Global.GameNewProduct.Graphics = (int)GetNode<HSlider>("../Slider3").Value;
        Global.GameNewProduct.MoneySpent = Global.GameNewProduct.Gameplay*100 +
            Global.GameNewProduct.Lore*100 + Global.GameNewProduct.Graphics*100;

        Text = "This product will cost $" + String.Format("{0:n0}", Global.GameNewProduct.MoneySpent);
        
        base._Process(delta);
    }
}
