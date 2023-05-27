using Godot;
using System;

public class LabProjectsOpen : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (Global.LabCurrentProject == "nothing") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/LabProjects.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
        } else {
            GetNode<Label>("./Label").Text = "You're already researching something!";
        }
    }
}
