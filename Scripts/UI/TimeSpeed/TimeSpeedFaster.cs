using Godot;
using System;

public class TimeSpeedFaster : TextureButton {
    Texture on;
    Texture onHover;
    Texture onPress;
    Texture off;
    Texture offHover;
    Texture offPress;

    public override void _Ready() {
        on = ResourceLoader.Load<Texture>("res://Assets/Speed3On.png");
        onHover = ResourceLoader.Load<Texture>("res://Assets/Speed3OnHover.png");
        onPress = ResourceLoader.Load<Texture>("res://Assets/Speed3OnPress.png");
        off = ResourceLoader.Load<Texture>("res://Assets/Speed3Off.png");
        offHover = ResourceLoader.Load<Texture>("res://Assets/Speed3OffHover.png");
        offPress = ResourceLoader.Load<Texture>("res://Assets/Speed3OffPress.png");
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TimeSpeed = 3;
    }

    public override void _Process(float delta) {
        if (Global.TimeSpeed == 3) {
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
