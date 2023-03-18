using Godot;
using System;

public class TimeSpeedNormal : TextureButton {
    Texture on;
    Texture off;

    public override void _Ready() {
        on = ResourceLoader.Load<Texture>("res://Assets/Speed1On.png");
        off = ResourceLoader.Load<Texture>("res://Assets/Speed1Off.png");
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TimeSpeed = 1;
    }

    public override void _Process(float delta) {
        if (Global.TimeSpeed == 1) {
            TextureNormal = on;
        } else {
            TextureNormal = off;
        }
        base._Process(delta);
    }
}
