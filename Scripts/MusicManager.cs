using Godot;
using System;

public class MusicManager : AudioStreamPlayer2D {
    string[] moosics = {
        "Local Forecast - Slower",
        "Airport Lounge",
        "Dispersion Relation",
        "George Street Shuffle",
        "Aces High"
    };

    public override void _Ready() {
        Connect("finished", this, nameof(PlayMoosic));
        PlayMoosic();
    }

    public override void _Process(float delta) {
        // Having to hear the entire thing just to see if it's gonna choose another song is kinda annoying
        // WARNING: THIS IS GONNA LOAD A BUNCH OF MOOSIC FOR NO REASON (TOO LAZY TO FIX)
        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.Control) &&
            Input.IsPhysicalKeyPressed((int)Godot.KeyList.Shift) &&
            Input.IsPhysicalKeyPressed((int)Godot.KeyList.Alt) &&
            Input.IsPhysicalKeyPressed((int)Godot.KeyList.Space)
        )
            PlayMoosic();

        base._Process(delta);
    }

    public void PlayMoosic() {
        StreamPaused = true;
        Random soRandom = new Random();
        AudioStream audio = ResourceLoader.Load<AudioStream>(
            "res://Music/" + moosics[soRandom.Next(5)] + ".mp3");
        Stream = audio;
        Play();
        GD.Print(audio.ResourcePath);
        StreamPaused = false;
    }
}
