using Godot;
using System;

public class BrokenMod : Sprite {
    bool Okbye = false;
    float Alpha = 1;

    public override void _Ready() {
        base._Ready();
        Timer bruh = new Timer();
        bruh.Connect("timeout", this, nameof(Bye));
        bruh.OneShot = true;
        bruh.WaitTime = 5;
        AddChild(bruh);
        bruh.Start();
    }

    public override void _Process(float delta) {
        if (Okbye) {
            Alpha -= 0.05f;
            if (Alpha < 0)
                GetParent().QueueFree();
            else
                Modulate = new Color(1, 1, 1, Alpha);
        }
        base._Process(delta);
    }

    public void Bye() {
        Okbye = true;
    }
}
