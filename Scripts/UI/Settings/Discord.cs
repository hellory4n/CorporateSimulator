using Godot;
using System;

public class Discord : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        OS.ShellOpen("https://discord.gg/mSb9bbeJ8S");
    }
}
