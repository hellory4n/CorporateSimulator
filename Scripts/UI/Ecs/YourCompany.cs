using Godot;
using System;

public class YourCompany : TextureButton {
    public override void _Ready() {
        GetNode<Label>("./Label").Text = Global.CompanyName;
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/News/Computer/EcsYourCompany1.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
    }
}
