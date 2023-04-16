using Godot;
using System;

public class RealCompanyBoom : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Directory wowie = new Directory();
        wowie.Remove(Global.CompanyThatWillSoonExplode);
        GetNode<Node2D>("/root/Saves").QueueFree();
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Saves.tscn");
        Node2D OK = (Node2D)yes.Instance();
        GetTree().Root.AddChild(OK);
        GetParent().GetParent().QueueFree();
    }
}
