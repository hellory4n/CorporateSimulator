using Godot;
using System;

public class InvestorBankrupcy : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Money -= 100000000;
        GetParent().QueueFree();
    }
}
