using Godot;
using System;

public class MusicManager : AudioStreamPlayer {
    string[] moosics = {
        "First Degree Murder Tutorial",
        "Pain LLC",
        "Tax Fraud",
        "Very Chill Moosic for Taking Over the World",
        "We Hate Customers"
    };
    string currentMoosic = "none";

    public override void _Ready() {
        Connect("finished", this, nameof(ChooseMoosic));
        ChooseMoosic();
    }

    public override void _Process(float delta) {
        // Having to hear the entire thing just to see if it's gonna choose another song is kinda annoying
        // WARNING: THIS IS GONNA LOAD A BUNCH OF MOOSIC FOR NO REASON (TOO LAZY TO FIX)
        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.Control) &&
            Input.IsPhysicalKeyPressed((int)Godot.KeyList.Shift) &&
            Input.IsPhysicalKeyPressed((int)Godot.KeyList.Alt) &&
            Input.IsPhysicalKeyPressed((int)Godot.KeyList.Space)
        )
            ChooseMoosic();

        base._Process(delta);
    }

    public void PlayMoosic(AudioStream bruh) {
        Stream = bruh;
        Play();
    }

    public void ChooseMoosic() {
        Random random = new Random();
        // shuffle the music array
        for (int i = moosics.Length - 1; i > 0; i--) {
            int j = random.Next(i + 1);
            string temp = moosics[j];
            moosics[j] = moosics[i];
            moosics[i] = temp;
        }
        // GD.Print("current list: ", moosics[0], moosics[1], moosics[2], moosics[3], moosics[4]);
        string epicMusicThatWillBePlayed = moosics[random.Next(moosics.Length)];
        if (epicMusicThatWillBePlayed == currentMoosic)
            ChooseMoosic();

        AudioStream fantasticSounds = ResourceLoader.Load<AudioStream>("res://Music/" +
            epicMusicThatWillBePlayed + ".mp3");
        
        PlayMoosic(fantasticSounds);
        GD.Print("now playing: " + epicMusicThatWillBePlayed + " - previous music: " + currentMoosic);
        currentMoosic = epicMusicThatWillBePlayed;
    }
}
