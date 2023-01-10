using Godot;
using System;

public class ElectronicsNext : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.ElectronicsNewProduct.Name = GetNode<LineEdit>("../ProductName").Text;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Electronics2.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
