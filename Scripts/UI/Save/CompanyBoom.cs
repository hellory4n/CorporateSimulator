using Godot;
using System;

public class CompanyBoom : TextureButton {
    [Export]
    int CompanyNumber;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetNode<Node2D>("../../../Boom").Visible = true;
    }
}
