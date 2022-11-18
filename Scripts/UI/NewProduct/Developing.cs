using Godot;
using System;

public class Developing : Label {
    int waitTime = 60;

    public override void _Ready() {
        Text = "Developing " + Global.DevelopingName + ": 0%";
        foreach (var idiot in Global.Employees) {
            if (idiot.Rating > 0)
                waitTime -= (int)idiot.Rating/2;
        }
        if (waitTime < 1)
            waitTime = 1;
        GD.Print(waitTime);
    }

    public override void _Process(float delta) {
        if (Engine.GetIdleFrames() % (ulong)waitTime == 0 && Global.PausedTime == false) {
            Global.DevelopingProgress++;
            Text = "Developing " + Global.DevelopingName + ": " + Global.DevelopingProgress + "%";
        }

        if (Global.DevelopingProgress == 100) {
            Global.Products.Add(Global.SpaceNewProduct);
            Global.ResearchPoints += 10;
            Global.Developing = null;
            QueueFree();
            Global.DevelopingProgress = 0;
        }

        base._Process(delta);
    }
}