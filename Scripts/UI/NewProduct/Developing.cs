using Godot;
using System;

public class Developing : Label {
    int waitTime = 30;

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
            if (Global.Developing is SpaceProduct)
                Global.Products.Add(Global.SpaceNewProduct);
                GD.Print("this is rocket");
            if (Global.Developing is BookProduct)
                Global.Products.Add(Global.BookNewProduct);

            Global.ResearchPoints += 10;
            Global.Developing = null;
            QueueFree();
            Global.DevelopingProgress = 0;
        }

        base._Process(delta);
    }
}