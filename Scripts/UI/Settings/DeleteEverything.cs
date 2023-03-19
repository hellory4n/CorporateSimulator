using Godot;
using System;

public class DeleteEverything : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetNode<Node2D>("../DeleteAll").Visible = true;
    }
}
