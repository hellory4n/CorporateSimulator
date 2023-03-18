using Godot;
using System;

public class TimeSpeedFast : TextureButton {
    Texture on;
    Texture off;

    public override void _Ready() {
        on = ResourceLoader.Load<Texture>("res://Assets/Speed2On.png");
        off = ResourceLoader.Load<Texture>("res://Assets/Speed2Off.png");
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TimeSpeed = 2;
    }

    public override void _Process(float delta) {
        if (Global.TimeSpeed == 2) {
            TextureNormal = on;
        } else {
            TextureNormal = off;
        }
        base._Process(delta);
    }
}
