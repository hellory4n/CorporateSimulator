using Godot;
using System;

public class PrivacyPolicy : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        OS.ShellOpen("https://hellory4n.github.io/corporate-simulator/privacy.html");
    }
}
