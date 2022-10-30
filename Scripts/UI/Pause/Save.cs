using Godot;
using System;

public class Save : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Savior.SaveGame(Global.SaveFile);
        GetNode("/root/PauseMenu").QueueFree();
        GetNode<TextureButton>("/root/Game/CanvasLayer/Pause").TextureNormal =
            ResourceLoader.Load<Texture>("res://Assets/MenuInactive.png");
        Global.PausedTime = false;
    }
}
