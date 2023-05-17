using Godot;
using System;

public class LawsuitOK : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Money += (int)Global.Money/20;
        GetParent().QueueFree();
    }
}
