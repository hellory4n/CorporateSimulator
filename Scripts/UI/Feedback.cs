using Godot;
using System;

public class Feedback : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        OS.ShellOpen("https://forms.gle/JYARMReHx4zb5x4R6");
    }
}
