using Godot;
using System;

public class CreditsScroll : Label {
    public override void _Ready() {
        Global.PausedTime = true;
        base._Ready();
    }

    public override void _Process(float delta) {
        // Highly complicated code
        RectPosition = new Vector2(RectPosition.x, RectPosition.y-(50*delta));
        GD.Print(RectPosition.y);

        if (RectPosition.y < -2800)
            GetNode("/root/CreditsThing").QueueFree();
            Global.PausedTime = false;

        base._Process(delta);
    }
}
