using Godot;
using System;

public class TimeSpeedOpen : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TimeSpeedMenu = !Global.TimeSpeedMenu;
    }
}
