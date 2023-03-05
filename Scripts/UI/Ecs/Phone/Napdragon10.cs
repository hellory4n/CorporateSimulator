using Godot;
using System;

public class Napdragon10 : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/News/Phone/EcsNapdragon10.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
    }
}
