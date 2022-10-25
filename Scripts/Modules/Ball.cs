using Godot;
using System;

public class Ball : Node2D {
    string texturePath;
    string scene;

    public void Init(string type, string _scene) {
        // What kind of balls this is
        switch (type) {
            case "news":
                texturePath = "res://Assets/NewsBall.png";
                break;
            // TODO: add other ball types
        }
        // What scene the balls should open
        scene = "res://Scenes/" + _scene + ".tscn";
    }

    public override void _Ready() {
        // Init the balls
        this.Position = new Vector2(75, -100);
        Texture balls = ResourceLoader.Load<Texture>(texturePath);
        Sprite balls_ = new Sprite();
        balls_.Texture = balls; // TODO: write good code
        AddChild(balls_);
        base._Ready();
    }

    public override void _Process(float delta) {
        if (Position.y > 640 && Position.x == 75) {
            // instantly opening the thing is kinda crinj y'know
            Timer timer = new Timer();
            timer.Connect("timeout", this, nameof(OpenThingy));
            timer.WaitTime = 1;
            timer.OneShot = true;
            AddChild(timer);
            timer.Start();
            Position = new Vector2(76, Position.y); // don't make millions of timers
        }
        if (Position.y < 640) {
            Position = new Vector2(Position.x, Position.y + 500 * delta);
        }
        base._Process(delta);
    }

    public void OpenThingy() {
        var yes = (PackedScene)ResourceLoader.Load(scene);
        Node2D OK = (Node2D)yes.Instance();
        GetTree().Root.AddChild(OK);
        QueueFree();
    }
}
