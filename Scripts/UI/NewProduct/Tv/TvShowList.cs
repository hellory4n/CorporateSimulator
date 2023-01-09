using Godot;
using System;

public class TvShowList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/TvShowButton.tscn");
        
        var OK = (TvShowButton)yes.Instance();
        OK.Init("Cartoon");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Talk show");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Cooking");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("DIY");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Documentary");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Game show");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Movie");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("News");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Reality show");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Sitcom");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Soap opera");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("TV series");
        AddChild(OK);

        OK = (TvShowButton)yes.Instance();
        OK.Init("Wildlife");
        AddChild(OK);
        base._Ready();
    }
}
