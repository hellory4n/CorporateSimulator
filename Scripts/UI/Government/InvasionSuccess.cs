using Godot;
using System;

public class InvasionSuccess : Label {
    public override void _Ready() {
        Text = $"You have successfully invaded {Global.InvadedCountry}!";
        base._Ready();
    }
}
