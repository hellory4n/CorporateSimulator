using Godot;
using System;

public class StockMarketBuy : TextureButton {
    [Export]
    string Company = "bruh inc";
    [Export]
    int epicIndex = 0;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        // calculate the epic price
        int bruh = (int)Global.Money/1000000+1;
        Global.AvailableInvestments[epicIndex].Price = Global.AvailableInvestments[epicIndex].Price*bruh;
        // update the epic slider
        Slider epicSlider = GetNode<Slider>("../EpicSlider");
        GetNode<Label>("../EpicSlider/Label").Text = $"Stocks: {String.Format("{0:n0}", epicSlider.Value)} - Price: ${String.Format("{0:n0}", Global.AvailableInvestments[epicIndex].Price*epicSlider.Value)}";
        base._Process(delta);
    }

    public void Click() {
        
    }
}
