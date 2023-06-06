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

        Slider epicSlider = GetNode<Slider>("../EpicSlider");
        GetNode<Label>("../EpicSlider/Label").Text = $"{epicSlider.Value} selected";
        base._Process(delta);
    }

    public void Click() {
        // epic calculations
        Slider uh = GetNode<Slider>("../EpicSlider");
        int amountWanted = (int)uh.Value;
        int available = 100;

        if (MilitaryCategoryThing == "army")
            available = 100-Global.Army[MilitaryThing];
        if (MilitaryCategoryThing == "navy")
            available = 100-Global.Navy[MilitaryThing];
        if (MilitaryCategoryThing == "air force")
            available = 100-Global.AirForce[MilitaryThing];

        double canBuy = Math.Min(Global.Money / Cost, available);
        if (canBuy < amountWanted)
            amountWanted = (int)canBuy;
        
        // actually upgrade the cool military
        if (MilitaryCategoryThing == "army")
            Global.Army[MilitaryThing] += amountWanted;
        if (MilitaryCategoryThing == "navy")
            Global.Navy[MilitaryThing] += amountWanted;
        if (MilitaryCategoryThing == "air force")
            Global.AirForce[MilitaryThing] += amountWanted;
        
        Global.Money -= Cost * amountWanted;
    }
}
