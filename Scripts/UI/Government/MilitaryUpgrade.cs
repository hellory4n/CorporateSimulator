using Godot;
using System;

public class MilitaryUpgrade : TextureButton {
    [Export]
    int MilitaryThing = 0;
    [Export]
    long Cost = 69420;
    [Export]
    string MilitaryCategoryThing = "gun department";

    /*public override void _Process(float delta) {
        #region this sucks ngl
        if (MilitaryThing == "Soldiers")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.Soldiers}/100";
        if (MilitaryThing == "Ammo")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.Ammo}/100";
        if (MilitaryThing == "Infantry Weapons")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.InfantryWeapons}/100";
        if (MilitaryThing == "Armored Cars")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.ArmoredCars}/100";
        if (MilitaryThing == "Combat Vehicles")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.CombatVehicles}/100";
        if (MilitaryThing == "Artillery")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.Artillery}/100";
        if (MilitaryThing == "RPG")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.RPG}/100";
        if (MilitaryThing == "BallisticMissiles")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.BallisticMissiles}/100";
        if (MilitaryThing == "Tanks")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.Tanks}/100";
        if (MilitaryThing == "Mass Destruction")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Army.MassDestruction}/100";
        if (MilitaryThing == "Sailors")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Navy.Sailors}/100";
        if (MilitaryThing == "Sailoaaaaars")
            GetNode<Label>("../Name").Text = $"{MilitaryThing}: {Global.Navy.Sailors}/100";
        #endregion
        Slider epicSlider = GetNode<Slider>("../EpicSlider");
        //GetNode<Label>("../EpicSlider/Label").Text = $"Stocks: {String.Format("{0:n0}", epicSlider.Value)} - Price: ${String.Format("{0:n0}", (Global.AvailableInvestments[epicIndex].Price*bruh)*epicSlider.Value)}";
        base._Process(delta);
    }

    public void Click() {
        Slider uh = GetNode<Slider>("../EpicSlider");
        //long jsjskhsksk = (long)Math.Round((Global.AvailableInvestments[epicIndex].Price*bruh)*uh.Value);
        //Global.Investments[epicIndex].Amount += (int)uh.Value;
        //Global.Money -= jsjskhsksk;
        // i have to do a mess to make the ui look right
        GetParent().GetParent().GetParent().GetParent().GetParent().QueueFree();
    }*/
}
