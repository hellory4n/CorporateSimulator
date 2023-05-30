using Godot;
using System;

public class GovernmentOpen : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        if (Global.GovernmentUnlocked) {
            RectPosition = new Vector2(1040, 645);
        } else {
            RectPosition = new Vector2(69420, 69420);
        }
        base._Process(delta);
    }

    public void Click() {
        if (GetNodeOrNull("/root/Government") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Government.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
        } else
            GetNode("/root/Government").QueueFree();
    }
}
