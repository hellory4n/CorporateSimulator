using Godot;
using System;

public class SettingsLoader : Node2D {
    public override void _Ready() {
        Global.Settings = Savior.CreateFileStuff();
        
        // music :)
        if (Global.Settings.Music) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/MusicManager.tscn");
            Node2D OK = (Node2D)yes.Instance();
            // if i do it immediately godot will complain that it's busy setting up stuff
            GetTree().Root.CallDeferred("add_child", OK);
        }

        // fullscreen :)
        Godot.OS.WindowFullscreen = Global.Settings.Fullscreen;
        base._Ready();
    }
}
