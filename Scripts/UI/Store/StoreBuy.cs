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
    }

    public void Click() {
        
    }
}
