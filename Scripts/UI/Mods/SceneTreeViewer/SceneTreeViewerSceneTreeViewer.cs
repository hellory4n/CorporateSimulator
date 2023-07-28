using Godot;
using System;

public class SceneTreeViewerSceneTreeViewer : Tree {
    public override void _Ready() {
        base._Ready();
        TreeItem root = CreateItem();
        ListNodes(GetTree().Root, ref root, this, 0);
    }

    TreeItem ListNodes(Node node, ref TreeItem parent, Tree tree, int depth) {
        TreeItem veryCoolNode = tree.CreateItem(parent);
        veryCoolNode.SetText(depth, $"{node.Name} - {node.GetType().Name}");

        // recursion ogmgomsgnofgrgmhkçkophgm
        for (int i = 0; i < node.GetChildCount(); i++) {
            ListNodes(node.GetChild(i), ref veryCoolNode, tree, depth + 1);
        }

        return veryCoolNode;
    }
}
