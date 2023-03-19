using Godot;
using System;

public class CancelDeleteAll : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetParent<Node2D>().Visible = false;
    }
}
