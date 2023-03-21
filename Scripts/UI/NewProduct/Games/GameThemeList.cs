using Godot;
using System;

public class GameThemeList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/GameThemeButton.tscn");
        
        var OK = (GameThemeButton)yes.Instance();
        OK.Init("Airplane");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Aliens");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Alternate History");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Business");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("City");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Comedy");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Cyberpunk");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Dance");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Detective");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Dungeon");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Evolution");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Fantasy");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Fashion");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Game Dev");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Government");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Hacking");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("History");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Horror");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Hospital");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Hunting");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Law");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Life");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Martial Arts");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Medieval");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Military");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Movies");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Music");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Mystery");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Ninja");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Pirate");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Post Apocalyptic");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Prison");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Racing");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Rhythm");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Romance");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("School");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Sci-Fi");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Space");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Sports");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Spy");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Superheroes");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Surgery");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Time Travel");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Transport");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("UFO");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Vampire");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Virtual Pet");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Vocabulary");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Werewolf");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Wild West");
        AddChild(OK);

        OK = (GameThemeButton)yes.Instance();
        OK.Init("Zombies");
        AddChild(OK);

        base._Ready();
    }
}
