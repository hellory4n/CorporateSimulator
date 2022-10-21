using Godot;
using System;

public class Game : Node2D {
    public override void _Ready() {
        GD.Print("hi mom");
        Button epokButton = new Button();
        epokButton.Init(
            "Menu", "epok button", "GodotSpriteToTestTheButton", "left", new Vector2(0, 0)
        );
        AddChild(epokButton);

        GD.Print(Global.Money);
    }

    public override void _Process(float delta) {
        base._Process(delta);
    }
}
