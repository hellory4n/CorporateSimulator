using Godot;
using System;

public class TvFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TvNewProduct.ProductionTime = (int)GetNode<HSlider>("../Slider1").Value;
        Global.TvNewProduct.Script = (int)GetNode<HSlider>("../Slider2").Value;
        Global.TvNewProduct.Ads = (int)GetNode<HSlider>("../Slider3").Value;

        Global.TvNewProduct.Type = "tv";
        Global.Money -= Global.TvNewProduct.MoneySpent;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.TvNewProduct;
        Global.DevelopingName = Global.TvNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
