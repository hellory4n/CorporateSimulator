using Godot;
using System;

public class MilitaryUpgrade : TextureButton {
    [Export]
    int MilitaryThing = 0;
    [Export]
    long Cost = 69420;
    [Export]
    string MilitaryCategoryThing = "gun department";
    [Export]
    string MilitaryNameThing = "shooty shooty bang bang";

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        base._Ready();
    }

    public override void _Process(float delta) {
        if (MilitaryCategoryThing == "army")
            GetNode<Label>("../Name").Text = $"{MilitaryNameThing}: {Global.Army[MilitaryThing]}/100";
        if (MilitaryCategoryThing == "navy")
            GetNode<Label>("../Name").Text = $"{MilitaryNameThing}: {Global.Navy[MilitaryThing]}/100";
        if (MilitaryCategoryThing == "air force")
            GetNode<Label>("../Name").Text = $"{MilitaryNameThing}: {Global.AirForce[MilitaryThing]}/100";
        
        GetNode<Label>("../Cost").Text = $"Can cost up to ${String.Format("{0:n0}", Cost*100)}";
        base._Process(delta);
    }

    public void Click() {
        // epic calculations
        int available = 100;

        if (MilitaryCategoryThing == "army")
            available = 100-Global.Army[MilitaryThing];
        if (MilitaryCategoryThing == "navy")
            available = 100-Global.Navy[MilitaryThing];
        if (MilitaryCategoryThing == "air force")
            available = 100-Global.AirForce[MilitaryThing];

        double canBuy = Math.Min(Global.Money / Cost, available);
        
        // actually upgrade the cool military
        if (MilitaryCategoryThing == "army")
            Global.Army[MilitaryThing] += (int)canBuy;
        if (MilitaryCategoryThing == "navy")
            Global.Navy[MilitaryThing] += (int)canBuy;
        if (MilitaryCategoryThing == "air force")
            Global.AirForce[MilitaryThing] += (int)canBuy;
        
        Global.Money -= Cost * (int)canBuy;
    }
}
