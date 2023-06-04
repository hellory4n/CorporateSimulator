using Godot;
using System;

public class StoreSellClose : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (Global.StoreGift != "nothing")
            Global.StoreGift = "nothing";
        if (GetNodeOrNull("/root/PauseThingy") != null)
            GetNode("/root/PauseThingy").QueueFree();
        GetParent().QueueFree();
    }
}
