using Godot;
using System;

public class InTells5 : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/News/Computer/EcsInTells5.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
    }
}