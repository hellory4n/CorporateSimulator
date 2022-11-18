using Godot;
using System;

public class SpaceFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.SpaceNewProduct.Type = "rocket";
        Global.Money -= Global.SpaceNewProduct.MoneySpent;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Developing/DevelopingSpace.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
