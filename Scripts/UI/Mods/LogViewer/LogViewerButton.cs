using Godot;
using System;

public class LogViewerButton : TextureButton {
    string ok;
    string pain;

    public void Init(string yeah, string mues) {
        ok = yeah; // you're welcome
        pain = mues; // why do i do this
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        GetNode<Label>("./Label").Text = pain;
    }

    public void Click() {
        Global.CurrentLogFile = ok;
        // restart the log viewer
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/LogViewer.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        GetParent().GetParent().GetParent().QueueFree();
    }
}
