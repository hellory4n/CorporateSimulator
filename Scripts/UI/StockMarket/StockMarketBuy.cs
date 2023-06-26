using Godot;
using System;

public class StockMarketBuy : TextureButton {
    [Export]
    string Company = "bruh inc";
    [Export]
    int epicIndex = 0;
    long bruh = (long)Global.Money/1000000+1;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        // update the epic slider
        Slider epicSlider = GetNode<Slider>("../EpicSlider");
        GetNode<Label>("../EpicSlider/Label").Text = $"Stocks: {String.Format("{0:n0}", epicSlider.Value)} - Price: ${String.Format("{0:n0}", (Global.AvailableInvestments[epicIndex].Price*bruh)*epicSlider.Value)}";
        base._Process(delta);
    }

    public void Click() {
        int amountWanted = (int)GetNode<Slider>("../EpicSlider").Value;
        long price = Global.AvailableInvestments[epicIndex].Price*bruh;
        // avoid people going bankrupt after buying too many stocks
        double maxQuantity = Global.Money / price;
        if (maxQuantity < amountWanted) {
            amountWanted = (int)maxQuantity;
        }

        Global.Investments[epicIndex].Amount += amountWanted;
        Global.Money -= price*amountWanted;
        // i have to do a mess to make the ui look right
        GetParent().GetParent().GetParent().GetParent().GetParent().QueueFree();
    }
}
