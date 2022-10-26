using Godot;
using System;

public class ButtonTest : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GD.Print("hi");
        /*var yes = (PackedScene)ResourceLoader.Load("res://Scenes/DialogTest.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);*/
        Global.PausedTime = !Global.PausedTime;
    }
}
