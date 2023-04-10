using Godot;
using System;

public class StockMarketSell : TextureButton {
    [Export]
    string Company = "bruh inc";
    [Export]
    int epicIndex = 0;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        // update the epic slider
        Slider epicSlider = GetNode<Slider>("../EpicSlider");
        epicSlider.MaxValue = Global.Investments[epicIndex].Amount;
        int bruh = (int)Global.Money/1000000+1;
        if (epicSlider.MaxValue > 0)
            GetNode<Label>("../EpicSlider/Label").Text = $"Stocks owned: {String.Format("{0:n0}", epicSlider.MaxValue)} - Stocks to be sold: {String.Format("{0:n0}", epicSlider.Value)} (${String.Format("{0:n0}", (Global.AvailableInvestments[epicIndex].Price*bruh)*epicSlider.Value)})";
        else
            GetNode<Label>("../EpicSlider/Label").Text = "You don't own any stocks from this company";
        base._Process(delta);
    }

    public void Click() {
        // i have to do a mess to make the ui look right
        GetParent().GetParent().GetParent().GetParent().GetParent().QueueFree();
    }
}
