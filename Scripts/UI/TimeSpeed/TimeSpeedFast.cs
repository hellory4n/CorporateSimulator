using Godot;
using System;

public class TimeSpeedFast : TextureButton {
    Texture on;
    Texture onHover;
    Texture onPress;
    Texture off;
    Texture offHover;
    Texture offPress;

    public override void _Ready() {
        on = ResourceLoader.Load<Texture>("res://Assets/Speed2On.png");
        onHover = ResourceLoader.Load<Texture>("res://Assets/Speed2OnHover.png");
        onPress = ResourceLoader.Load<Texture>("res://Assets/Speed2OnPress.png");
        off = ResourceLoader.Load<Texture>("res://Assets/Speed2Off.png");
        offHover = ResourceLoader.Load<Texture>("res://Assets/Speed2OffHover.png");
        offPress = ResourceLoader.Load<Texture>("res://Assets/Speed2OffPress.png");
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TimeSpeed = 2;
    }

    public override void _Process(float delta) {
        if (Global.TimeSpeed == 2) {
            TextureNormal = on;
            TextureHover = onHover;
            TexturePressed = onPress;
        } else {
            TextureNormal = off;
            TextureHover = offHover;
            TexturePressed = offPress;
        }
        base._Process(delta);
    }
}
