using Godot;
using System;

public class SceneTreeViewerThing : TextureButton {
    string ok;

    public void Init(string yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        Node pain = GetNode<Node>(Global.SceneTreeViewerPath+ok);
        GetNode<Label>("./Label").Text = $"{pain.Name} - {pain.GetType()}";
    }

    public void Click() {
        Global.SceneTreeViewerPath += ok + "/";
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/SceneTreeViewer.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        GetParent().GetParent().GetParent().QueueFree();
    }
}
