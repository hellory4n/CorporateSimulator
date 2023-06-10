using Godot;
using System;

public class SettingsLoader : Node2D {
    public override void _Ready() {
        Global.Settings = Savior.CreateFileStuff();
        Global.Achievements = Savior.CreateAchievements();
        
        // music :)
        if (Global.Settings.Music) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/MusicManager.tscn");
            AudioStreamPlayer OK = (AudioStreamPlayer)yes.Instance();
            // if i do it immediately godot will complain that it's busy setting up stuff
            GetTree().Root.CallDeferred("add_child", OK);
        }

        // epic exciting legal stuff
        File aFile = new File();
        if (!aFile.FileExists("user://legal_stuff")) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/LegalStuff.tscn");
            Node2D OK = (Node2D)yes.Instance();
            GetTree().Root.CallDeferred("add_child", OK);
        }

        // fullscreen :)
        Godot.OS.WindowFullscreen = Global.Settings.Fullscreen;
        base._Ready();
    }

    public override void _Process(float delta) {
        Godot.OS.WindowFullscreen = Global.Settings.Fullscreen;
        base._Process(delta);
    }
}
