using Godot;
using System;

public class BookGenreList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/BookGenreButton.tscn");
        
        var OK = (BookGenreButton)yes.Instance();
        OK.Init("Action and adventure");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Classics");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Comic book/Graphic novel");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Detective and mystery");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Fantasy");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Historical fiction");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Horror");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Literary fiction");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Romance");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Science fiction");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Short stories");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Suspense and thrillers");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Biographies");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Cookbooks");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Essays");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("History");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Memoir");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Poetry");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("Self-help");
        AddChild(OK);

        OK = (BookGenreButton)yes.Instance();
        OK.Init("True crime");
        AddChild(OK);

        base._Ready();
    }
}
