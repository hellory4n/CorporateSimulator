using Godot;
using System;

public class Continue : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GetNode("/root/PauseMenu").QueueFree();
        GetNode<TextureButton>("/root/Game/CanvasLayer/Pause").TextureNormal =
            ResourceLoader.Load<Texture>("res://Assets/MenuInactive.png");
    }
}
