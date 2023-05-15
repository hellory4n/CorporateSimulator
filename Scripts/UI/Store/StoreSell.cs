using Godot;
using System;

public class StoreSell : TextureButton {
    [Export]
    int ItemID = 0;

    public override void _Ready() {
        base._Ready();
        this.Connect("pressed", this, nameof(Click));
        // we don't need to show something we don't own :)
        if (Global.Purchased[ItemID].Amount == 0) {
            GetParent().QueueFree();
        }
        // i'm too lazy to update things in the editor lol, this scene is just a duplicate of the store buy stuff
        GetNode<Label>("./Label").Text = "Sell";
        // hope you have an ultrawide display or something
        GetNode<Label>("../ItemDescription").Text = $"Amount: {String.Format("{0:n0}", Global.Purchased[ItemID].Amount)}\nPrice: ${String.Format("{0:n0}", Global.Purchased[ItemID].Price)}\nMoney spent: ${String.Format("{0:n0}", Global.Purchased[ItemID].Amount*Global.Purchased[ItemID].Price)}";
    }

    public void Click() {
        Global.Purchased[ItemID].Amount -= 1;
        Global.Money += Global.Purchased[ItemID].Price;
        if (Global.Purchased[ItemID].Amount == 0) {
            GetParent().QueueFree();
        } else {
            // we need to update the amount :)
            GetNode<Label>("../ItemDescription").Text = $"Amount: {String.Format("{0:n0}", Global.Purchased[ItemID].Amount)}\nPrice: ${String.Format("{0:n0}", Global.Purchased[ItemID].Price)}\nMoney spent: ${String.Format("{0:n0}", Global.Purchased[ItemID].Amount*Global.Purchased[ItemID].Price)}";
        }
    }
}
