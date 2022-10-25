using Godot;
using System;

public class Game : Node2D {
    public override void _Ready() {
        GD.Print("hi mom");
        Ball balls = new Ball("news");
        balls.Position = new Vector2(1000, 420);
        AddChild(balls);
    }

    public override void _Process(float delta) {
        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.F11))
            OS.WindowFullscreen = !OS.WindowFullscreen;

        Global.WeekCounterThing += 1f * delta;

        // calculate time stuff
        if (Global.WeekCounterThing > 0.0001) {
            Global.Week++;
            Global.WeekCounterThing = 0;
        }
        if (Global.Week > 4) {
            Global.Month++;
            Global.Week = 1;
        }
        if (Global.Month > 12) {
            Global.Year++;
            Global.Month = 1;
        }

        base._Process(delta);
    }
}
