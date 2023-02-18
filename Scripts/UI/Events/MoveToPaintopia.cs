using Godot;
using System;

public class MoveToPaintopia : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Money -= 10000000000;
        Global.Reputation += 5;
        if (GetNodeOrNull("/root/PauseThingy") != null)
            GetNode("/root/PauseThingy").QueueFree();
        GetParent().QueueFree();
    }
}
