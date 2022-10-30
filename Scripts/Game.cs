using Godot;
using System;

public class Game : Node2D {
    // we need to know where to save
    public void Init(string saveFile) {
        Global.SaveFile = saveFile;
    }

    public override void _Ready() {
        GD.Print("hi mom");

        /*Ball balls = new Ball();
        balls.Init("news", "GodotSpriteToTestTheButton");
        AddChild(balls);*/

        // settings
        Global.Settings = Savior.CreateFileStuff();
        if (Global.Settings.Music) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/MusicManager.tscn");
            Node2D OK = (Node2D)yes.Instance();
            // if i do it immediately godot will complain that it's busy setting up stuff
            GetTree().Root.CallDeferred("add_child", OK);
        }
    }

    public override void _Process(float delta) {
        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.F11))
            OS.WindowFullscreen = !OS.WindowFullscreen;

        Global.WeekCounterThing += 1f * delta;

        // calculate time stuff
        if (!Global.PausedTime) {
            if (Global.WeekCounterThing > 1) {
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
        }

        base._Process(delta);
    }
}
