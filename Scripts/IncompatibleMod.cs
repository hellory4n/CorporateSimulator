using Godot;
using System;

public class IncompatibleMod : Label {
    public override void _Ready() {
        Text = $"Failed to load mods: {Global.IncompatibleMod} is made for Corporate Simulator v{Global.IncompatibleModVersion}, but you are running v1.1.0.";
        base._Ready();
    }
}
