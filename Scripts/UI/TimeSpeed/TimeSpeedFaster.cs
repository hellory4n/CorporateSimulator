using Godot;
using System;

public class TimeSpeedFaster : TextureButton {
    Texture on;
    Texture off;

    public override void _Ready() {
        on = ResourceLoader.Load<Texture>("res://Assets/Speed3On.png");
        off = ResourceLoader.Load<Texture>("res://Assets/Speed3Off.png");
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TimeSpeed = 3;
    }

    public override void _Process(float delta) {
        if (Global.TimeSpeed == 3) {
            TextureNormal = on;
        } else {
            TextureNormal = off;
        }
        base._Process(delta);
    }
}
