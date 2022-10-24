using Godot;
using System;

public class Game : Node2D {
    public override void _Ready() {
        GD.Print("hi mom");
        Button epokButton = new Button();
        epokButton.Init(
            "Menu", "epok button", "GodotSpriteToTestTheButton", "left", new Vector2(0, 0)
        );
        Ball balls = new Ball("news");
        balls.Position = new Vector2(1000, 420);
        AddChild(balls);
        
        AddChild(epokButton);
    }

    public override void _Process(float delta) {
        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.F11))
            OS.WindowFullscreen = !OS.WindowFullscreen;

        Global.WeekCounterThing += 1f * delta;
        GD.Print("week: " + Global.Week);
        GD.Print("week counter thing: ", Global.WeekCounterThing);

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
