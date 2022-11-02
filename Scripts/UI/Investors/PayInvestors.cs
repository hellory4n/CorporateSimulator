using Godot;
using System;

public class PayInvestors : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Money -= Global.InvestorsWant;
        Global.WeeksWithoutPayingInvestors = 0;
        Global.InvestorSusometer = 0;
        GetParent().QueueFree();
    }
}
