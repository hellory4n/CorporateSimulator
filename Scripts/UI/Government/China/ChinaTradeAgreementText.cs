using Godot;
using System;

public class ChinaTradeAgreementText : Label {
    public override void _Ready() {
        if (Global.China.TradeAgreement) {
            Text = "You have made a trade agreement with China! This will give you $1 billion every month.";
        } else {
            Text = "You need to have a diplomatic friendship of 75% or higher to make a trade agreement with China.";
        }
        base._Ready();
    }
}
