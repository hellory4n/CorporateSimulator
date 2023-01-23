using Godot;
using System;

public class InvestorStatistics : Label {
    public override void _Process(float delta) {
        Text = "Investors: "+String.Format("{0:n0}", Global.Investors)+"\nReputation: "+Global.Reputation+"%"
        +"\nNew investors every "+Global.InvestorFrequency+" weeks\nYou have to pay investors $"
        +String.Format("{0:n0}", Global.InvestorsWant)+"\nYou didn't pay investors for "+
        Global.WeeksWithoutPayingInvestors+" weeks\nEvery 2 months, if you don't pay investors, there'll"
        +" be less investors, and less money!\nBut they give you $"+String.Format("{0:n0}",
        Global.InvestorPayment)+" every month";
        base._Process(delta);
    }
}
