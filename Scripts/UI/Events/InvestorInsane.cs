using Godot;
using System;

public class InvestorInsane : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Reputation -= 5;
        GetParent().QueueFree();
    }
}