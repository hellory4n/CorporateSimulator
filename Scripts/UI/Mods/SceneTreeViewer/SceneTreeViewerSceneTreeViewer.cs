using Godot;
using System;

public class SceneTreeViewerSceneTreeViewer : Label {
    public override void _Ready() {
        base._Ready();
        string tree = "";
        ListNodes(GetTree().Root, ref tree, 0);
        Text = tree;
    }

    void ListNodes(Node node, ref string formattedTree, int depth) {
        // each indent thing is 4 spaces cuz yes
        formattedTree += new string(' ', depth*8);
        formattedTree += $"{node.Name} - {node.GetType().Name}\n";

        // recursion ogmgomsgnofgrgmhkçkophgm
        for (int i = 0; i < node.GetChildCount(); i++) {
            ListNodes(node.GetChild(i), ref formattedTree, depth + 1);
        }
    }
}
