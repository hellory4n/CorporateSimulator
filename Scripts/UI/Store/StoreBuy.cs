using Godot;
using System;

public class StoreBuy : TextureButton {
    [Export]
    int ItemID = 0;
    [Export]
    int Price = 69;
    [Export]
    int Year = 1;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        // unlock store item system thing
        if (Global.Year < Year) {
            GetParent().QueueFree();
        }
    }

    public void Click() {
        Global.Purchased[ItemID].Amount += 1;
        Global.Purchased[ItemID].Price = Price;
        Global.Money -= Price;
    }
}
