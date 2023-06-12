using Godot;
using System;

public class CreditsScroll : Label {
    public override void _Ready() {
        base._Ready();
    }

    public override void _Process(float delta) {
        // Highly complicated code
        RectPosition = new Vector2(RectPosition.x, RectPosition.y-(50*delta));
        GD.Print(RectPosition.y);

        if (RectPosition.y < -3000)
            GetParent().QueueFree();

        base._Process(delta);
    }
}
