using Godot;
using System;

public class YourArseVideo : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/YourArseVideoButton.tscn");
        
        var OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Vlog");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Tutorial");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Q&A");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Top 10");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Review");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Education");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Challenge");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Unboxing");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Reaction");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Podcast");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Commentary");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Comedy");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Corporate");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Music");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Narrative");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Gameplay");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Live");
        AddChild(OK);

        OK = (YourArseVideoButton)yes.Instance();
        OK.Init("Piracy");
        AddChild(OK);
        base._Ready();
    }
}
