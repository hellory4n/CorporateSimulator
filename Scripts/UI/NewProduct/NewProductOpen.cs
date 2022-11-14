using Godot;
using System;

public class NewProductOpen : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        switch (Global.Industries[0]) {
            case "space":
                var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Space.tscn");
                Node2D OK = (Node2D)yes.Instance();
                OK.ZIndex = 100;
                GetTree().Root.AddChild(OK);
                break;
        }
    }
}
