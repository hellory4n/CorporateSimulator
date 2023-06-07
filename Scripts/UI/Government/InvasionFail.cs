using Godot;
using System;

public class InvasionFail : Label {
    public override void _Ready() {
        Text = $"You failed to invade {Global.InvadedCountry}. Make sure to upgrade your army, navy, and air force to successfully invade countries!";
        base._Ready();
    }
}
