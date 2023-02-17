using Godot;
using System;

public class SendHack : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Money -= 100000;
        Texture j = ResourceLoader.Load<Texture>("res://Assets/Scammed.png");
        Sprite shoot = new Sprite();
        shoot.Texture = j;
        shoot.Position = new Vector2(420, 420);
        GetTree().Root.AddChild(shoot);
        if (GetNodeOrNull("/root/PauseThingy") != null)
            GetNode("/root/PauseThingy").QueueFree();
        GetParent().QueueFree();
    }
}
