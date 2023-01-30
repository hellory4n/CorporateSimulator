using Godot;
using System;

public class ViralLabel : Label {
    public override void _Ready() {
        dynamic thej = Global.Products[Global.Products.Count-1];
        Text = thej.Name + " is going viral!";
        base._Ready();
    }
}
