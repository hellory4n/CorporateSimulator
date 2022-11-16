using Godot;
using System;

public class Pause : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (GetNodeOrNull("/root/PauseMenu") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/PauseMenu.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 128;
            GetTree().Root.AddChild(OK);
            this.TextureNormal = ResourceLoader.Load<Texture>("res://Assets/MenuActive.png");
        } else {
            GetNode("/root/PauseMenu").QueueFree();
            this.TextureNormal = ResourceLoader.Load<Texture>("res://Assets/MenuInactive.png");
        }
    }
}
