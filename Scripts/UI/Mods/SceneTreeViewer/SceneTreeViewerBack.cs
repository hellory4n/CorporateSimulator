using Godot;
using System;

public class SceneTreeViewerBack : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Node currentNode = GetNode<Node>(Global.SceneTreeViewerPath);
        Global.SceneTreeViewerPath = currentNode.GetParent().GetPath()+"/";
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/SceneTreeViewer.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        GetParent().GetParent().GetParent().QueueFree();
    }
}
