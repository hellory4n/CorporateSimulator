using Godot;
using System;

public class TimeSpeedMenu : Node2D {
    public override void _Process(float delta) {
        Visible = Global.TimeSpeedMenu;
        base._Process(delta);
    }
}
