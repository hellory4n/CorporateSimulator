using Godot;
using System;

public class PhoneNext : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.PhoneNewProduct.Name = GetNode<LineEdit>("../ProductName").Text;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Phone2.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
