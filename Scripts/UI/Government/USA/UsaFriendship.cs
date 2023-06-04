using Godot;
using System;

public class UsaFriendship : Label {
    public override void _Process(float delta) {
        Text = "Diplomatic Friendship: " + Global.UnitedStates.Friendship.ToString("0.0") + "%";
        // ally
        if (Global.UnitedStates.Friendship > 60) {
            this.AddColorOverride("font_color", new Color(0.242f, 0.726f, 0.285f, 1));
        // enemy
        } else if (Global.UnitedStates.Friendship < 40) {
            this.AddColorOverride("font_color", new Color(1f, 0.281f, 0.394f, 1));
        // doesn't care about you
        } else {
            this.AddColorOverride("font_color", new Color(0f, 0f, 0f, 1f));
        }
        base._Process(delta);
    }
}
