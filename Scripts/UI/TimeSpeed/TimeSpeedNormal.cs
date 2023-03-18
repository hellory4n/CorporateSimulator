using Godot;
using System;

public class TimeSpeedNormal : TextureButton {
    Texture on;
    Texture onHover;
    Texture onPress;
    Texture off;
    Texture offHover;
    Texture offPress;

    public override void _Ready() {
        on = ResourceLoader.Load<Texture>("res://Assets/Speed1On.png");
        onHover = ResourceLoader.Load<Texture>("res://Assets/Speed1OnHover.png");
        onPress = ResourceLoader.Load<Texture>("res://Assets/Speed1OnPress.png");
        off = ResourceLoader.Load<Texture>("res://Assets/Speed1Off.png");
        offHover = ResourceLoader.Load<Texture>("res://Assets/Speed1OffHover.png");
        offPress = ResourceLoader.Load<Texture>("res://Assets/Speed1OffPress.png");
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TimeSpeed = 1;
    }

    public override void _Process(float delta) {
        if (Global.TimeSpeed == 1) {
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
