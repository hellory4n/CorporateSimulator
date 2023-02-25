using Godot;
using System;

public class MessagingAppRefuse : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Reputation -= 20;
        if (GetNodeOrNull("/root/PauseThingy") != null)
            GetNode("/root/PauseThingy").QueueFree();
        GetParent().QueueFree();
    }
}
