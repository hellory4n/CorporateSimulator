using Godot;
using System;

public class MoreCO2 : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Reputation += 10;
        Global.Money -= 50000;
        if (GetNodeOrNull("/root/PauseThingy") != null)
            GetNode("/root/PauseThingy").QueueFree();
        GetParent().QueueFree();
    }
}
