using Godot;
using System;

public class Ball : Node2D {
    string texturePath;
    string scene;
    Timer timer = new Timer();

    public void Init(string type, string _scene) {
        // What kind of balls this is
        switch (type) {
            case "news":
                texturePath = "res://Assets/NewsBall.png";
                break;
            case "review":
                texturePath = "res://Assets/ReviewsBall.png";
                break;
            case "debt":
                texturePath = "res://Assets/BankruptBall.png";
                break;
            case "email":
                texturePath = "res://Assets/EmailBall.png";
                break;
            case "unlock":
                texturePath = "res://Assets/UnlockBall.png";
                break;
            case "ecs":
                texturePath = "res://Assets/EcsBall.png";
                break;
            case "end":
                texturePath = "res://Assets/EndBall.png";
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
            timer.Connect("timeout", this, nameof(OpenThingy));
            timer.WaitTime = 1;
            timer.OneShot = true;
            AddChild(timer);
            timer.Start();
            Position = new Vector2(76, Position.y); // don't make millions of timers
        }

        timer.Paused = Global.PausedTime;

        if (Position.y < 640 && !Global.PausedTime) {
            Position = new Vector2(Position.x, Position.y + 500 * delta);
        }
        base._Process(delta);
    }

    public void OpenThingy() {
        var yes = (PackedScene)ResourceLoader.Load(scene);
        Node2D OK = (Node2D)yes.Instance();
        GetTree().Root.AddChild(OK);

        if (GetNodeOrNull("/root/PauseThingy") == null) {
            yes = (PackedScene)ResourceLoader.Load("res://Scenes/PauseThingy.tscn");
            OK = (Node2D)yes.Instance();
            GetTree().Root.AddChild(OK);
        }
        QueueFree();
    }
}
