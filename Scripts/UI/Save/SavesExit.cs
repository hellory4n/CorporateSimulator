using Godot;
using System;

public class SavesExit : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (GetNodeOrNull("/root/Game") == null)
            GetTree().Quit();
        else
            GetParent().QueueFree();
    }
}
