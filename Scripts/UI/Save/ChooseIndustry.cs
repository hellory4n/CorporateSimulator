using Godot;
using System;

public class ChooseIndustry : TextureButton {
    public override void _Ready() {
        Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetParent().QueueFree();
    }
}
