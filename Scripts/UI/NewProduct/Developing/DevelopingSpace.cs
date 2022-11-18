using Godot;
using System;

public class DevelopingSpace : Label {
    int progress = 0;
    int waitTime = 60;

    public override void _Ready() {
        Text = "Developing " + Global.SpaceNewProduct.Name + ": 0%";
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
            progress++;
            Text = "Developing " + Global.SpaceNewProduct.Name + ": " + progress + "%";
        }

        if (progress == 100) {
            Global.Products.Add(Global.SpaceNewProduct);
            Global.ResearchPoints += 10;
            QueueFree();
            progress = 101;
        }

        base._Process(delta);
    }
}