using Godot;
using System;

public class Credits : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (GetNodeOrNull("/root/CreditsThing") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Credits.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 101;
            GetTree().Root.AddChild(OK);
        }
    }
}
