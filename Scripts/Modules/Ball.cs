using Godot;
using System;

public class Ball : Node2D {
    string texturePath;

    public Ball(string type) {
        // What kind of balls this is
        switch (type) {
            case "news":
                texturePath = "res://Assets/NewsBall.png";
                break;
            // TODO: add other ball types
        }
    }

    public override void _Ready() {
        // Init the balls
        Texture balls = ResourceLoader.Load<Texture>(texturePath);
        Sprite balls_ = new Sprite();
        balls_.Texture = balls; // TODO: write good code
        AddChild(balls_);
        base._Ready();
    }
}
