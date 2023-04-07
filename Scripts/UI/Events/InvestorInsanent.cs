using Godot;
using System;

public class InvestorInsanent : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Money += 50000000;
        Global.InvestorsInvested = true;
        GetParent().QueueFree();
    }
}
