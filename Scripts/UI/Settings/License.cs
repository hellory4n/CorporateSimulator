using Godot;
using System;

public class License : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        OS.ShellOpen("https://www.gnu.org/licenses/gpl-3.0.en.html");
    }
}
