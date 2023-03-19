using Godot;
using System;

public class Autosave : Timer {
    public override void _Ready() {
        Connect("timeout", this, nameof(Timeout));
    }

    public void Timeout() {
        if (!Global.RipAllGameData)
            Savior.SaveGame(Global.SaveFile);
    }
}
