using Godot;
using System;

public class FoodTypeButton : TextureButton {
    string ok;

    public void Init(string yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        GetNode<Label>("Label").Text = ok;
    }

    public void Click() {
        Global.FoodNewProduct.FoodType = ok.ToLower();
        // this button is inside a vboxcontainer inside a scrollcontainer inside a node2d
        GetParent().GetParent().GetParent().QueueFree();
    }
}