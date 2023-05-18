using Godot;
using System;

public class TechStuff : Label {
    public override void _Ready() {
        Random humor = new Random();
        int losses = humor.Next(5000, 850000);
        Text = $"Hello! I'm your advisor, Linus Droppinson. I bought a lot of epic technology that made the office become future, however that cost ${String.Format("{0:n0}", losses)}. I hope you understand the importance of becoming future.";
        Global.Money -= losses;
    }
}
