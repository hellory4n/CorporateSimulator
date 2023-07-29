using Godot;
using System;
using System.Text.RegularExpressions;

public class SceneTreeViewerThing : TextureButton {
    string ok;

    public void Init(string yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        Node pain = GetNode<Node>(Global.SceneTreeViewerPath+ok);
        // if the node has an script attached then GetType() doesn't say the type the node extends from, which
        // would be what we want
        string coolType = pain.GetType().Name;
        Script script = (Script)pain.GetScript();
        if (script != null) {
            coolType = ClassDB.GetParentClass(script.ResourceName);
        }
        GetNode<Label>("./Label").Text = $"{pain.Name} - {coolType}";
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
