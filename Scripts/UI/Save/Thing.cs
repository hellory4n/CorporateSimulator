using Godot;
using System;

public class Thing : Label {
    public override void _Ready() {
        Visible = Global.SavesMenuFromNewGame;
        base._Ready();
    }
}
