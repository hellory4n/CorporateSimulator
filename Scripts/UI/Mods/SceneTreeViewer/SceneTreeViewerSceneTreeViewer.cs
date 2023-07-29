using Godot;
using System;

public class SceneTreeViewerSceneTreeViewer : VBoxContainer {
    public override void _Ready() {
        base._Ready();
        // yes
        GetNode<Label>("./VeryCoolPath").Text = Global.SceneTreeViewerPath;
        if (Global.SceneTreeViewerPath == "/root/") {
            GetNode<TextureButton>("./Back").QueueFree();
        }

        // make the cool list of node children stuff
        try {
            Node currentNode = GetNode<Node>(Global.SceneTreeViewerPath);
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/SceneTreeViewerThing.tscn");
            for (int i = 0; i < currentNode.GetChildCount(); i++) {
                SceneTreeViewerThing OK = (SceneTreeViewerThing)yes.Instance();
                OK.Init(currentNode.GetChild(i).Name);
                AddChild(OK);
            }
        } catch {
            Global.SceneTreeViewerPath = "/root/";
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/SceneTreeViewer.tscn");
            Node2D OK = (Node2D)yes.Instance();
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            GetParent().GetParent().QueueFree();
        }
    }
}
