using Godot;
using System;

public class Autosave : Timer {
    public override void _Ready() {
        Connect("timeout", this, nameof(Timeout));
    }

    public void Timeout() {
        Savior.SaveGame(Global.SaveFile);
    }
}
