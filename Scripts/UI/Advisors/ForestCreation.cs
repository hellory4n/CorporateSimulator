using Godot;
using System;

public class ForestCreation : Label {
    public override void _Ready() {
        Random m = new Random();
        Text = $"Hello! I'm your advisor, Treeresa Bush. This month I planted {String.Format("{0:n0}", m.Next(999999999))} trees :)";
        Global.Reputation += 5;
        base._Ready();
    }
}
