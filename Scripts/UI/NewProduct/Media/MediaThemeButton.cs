using Godot;
using System;

public class MediaThemeButton : TextureButton {
    string ok;

    public void Init(string yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        GetNode<Label>("Label").Text = ok;
    }

    public void Click() {
        Global.MediaNewProduct.Theme = ok.ToLower();
        // this button is inside a vboxcontainer inside a scrollcontainer inside a node2d
        GetParent().GetParent().GetParent().QueueFree();
    }
}
