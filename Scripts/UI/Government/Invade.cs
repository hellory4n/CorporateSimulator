using Godot;
using System;

public class Invade : TextureButton {
    [Export]
    string CountryName = "bruh";
    [Export]
    double Army = 0;
    [Export]
    double Navy = 0;
    [Export]
    double AirForce = 0;

    public override void _Ready() {
        GetNode<Label>("../Name").Text = CountryName;
        GetNode<Label>("../Military").Text = $"Army: {Army.ToString("0.0")}/10 • Navy: {Navy.ToString("0.0")}/10 • Air Force: {AirForce.ToString("0.0")}";
        // you can't invade your own land
        if (Global.Invaded.Contains(CountryName))
            GetParent().GetParent().QueueFree();
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        // is the military of the player good enough to invade this country?
        int win = 0;
        double playerArmy = 0;
        foreach (var militaryThing in Global.Army) {
            playerArmy += militaryThing/100.0;
        }
        double playerNavy = 0;
        foreach (var militaryThing in Global.Navy) {
            playerNavy += militaryThing/100.0;
        }
        double playerAirForce = 0;
        foreach (var militaryThing in Global.AirForce) {
            playerAirForce += militaryThing/100.0;
        }
        if (playerArmy >= Army)
            win++;
        if (playerNavy >= Navy)
            win++;
        if (playerAirForce >= AirForce)
            win++;
        
        // explode the player's military
        for (int i = 0; i < Global.Army.Length; i++) {
            if (Global.Army[i] > Army*10)
                Global.Army[i] -= (int)Army*10;
            else
                Global.Army[i] = 0;
        }
        for (int i = 0; i < Global.Navy.Length; i++) {
            if (Global.Navy[i] > Navy*10)
                Global.Navy[i] -= (int)Navy*10;
            else
                Global.Navy[i] = 0;
        }
        for (int i = 0; i < Global.AirForce.Length; i++) {
            if (Global.AirForce[i] > AirForce*10)
                Global.AirForce[i] -= (int)AirForce*10;
            else
                Global.AirForce[i] = 0;
        }

        // show a cool thing to show the player that they have definitely successfully invaded a country
        Global.InvadedCountry = CountryName;
        if (win == 3) {
            Global.Invaded.Add(CountryName);
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Government/InvasionSuccess.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
        } else {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Government/InvasionFail.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
        }

        // this just closes the dialog
        GetParent().GetParent().GetParent().GetParent().GetParent().QueueFree();
    }
}
