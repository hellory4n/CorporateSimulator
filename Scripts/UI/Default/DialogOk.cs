using Godot;
using System;

public class DialogOk : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (Name != "DialogOkNot") {
            if (GetNodeOrNull("/root/PauseThingy") != null)
                GetNode("/root/PauseThingy").QueueFree();
        }
        GetParent().QueueFree();
    }
}
