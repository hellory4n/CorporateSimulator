using Godot;
using System;

public class UsaGift : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.StoreGift = "usa";
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/StoreOwned.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
    }
}
