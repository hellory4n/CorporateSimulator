using Godot;
using System;

public class Exit : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetTree().Quit();
    }
}
