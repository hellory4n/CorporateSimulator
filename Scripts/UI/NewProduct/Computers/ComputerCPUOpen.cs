using Godot;
using System;

public class ComputerCPUOpen : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerCPU.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
    }
}
