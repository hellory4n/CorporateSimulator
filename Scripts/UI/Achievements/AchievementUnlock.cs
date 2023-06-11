using Godot;
using System;

public class AchievementUnlock : Node2D {
    string achievement;
    Texture icon;
    // 0: hi
    // 1: doing nothing
    // 2: ok bye
    int animationMode = 0;

    public void Init(string achievementThatIsCool) {
        achievement = achievementThatIsCool;
    }

    public override void _Ready() {
        switch (achievement) {
            case "Corporate Simulator":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/CorporateSimulator.png");
                break;
            case "Multimillionaire":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/Multimillionaire.png");
                break;
            case "Billionaire":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/Billionaire.png");
                break;
            case "Business Boomin'":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/BusinessBoomin.png");
                break;
            case "Wealth Beyond Comprehension":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/WealthBeyondComprehension.png");
                break;
            case "Oopsie":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/Oopsie.png");
                break;
            case "Together Strong":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/TogetherStrong.png");
                break;
            case "Work Harder, Not Smarter":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/WorkHarderNotSmarter.png");
                break;
            case "Untouchable":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/Untouchable.png");
                break;
            case "Suspicious Business Amongst Us":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/SussyBusinessAmongstUs.png");
                break;
            case "Decade of Progress":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/DecadeOfProgress.png");
                break;
            case "Corporate Empire":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/CorporateEmpire.png");
                break;
            case "Unstoppable":
                icon = ResourceLoader.Load<Texture>("res://Assets/Achievements/Unstoppable.png");
                break;
        }

        GetNode<Sprite>("./Fart").Texture = icon;
        GetNode<Label>("./Achievement").Text = achievement;

        AudioStreamPlayer bsgksj = new AudioStreamPlayer();
        bsgksj.Stream = ResourceLoader.Load<AudioStreamMP3>("res://Uhh/achievement.mp3");
        bsgksj.Autoplay = true;
        AddChild(bsgksj);
    }

    public override void _Process(float delta) {
        // cool animation
        if (animationMode == 0) {
            if (Position.y > 0) {
                // wait a bit before going away
                Timer timer = new Timer();
                timer.Connect("timeout", this, nameof(Bruh));
                timer.WaitTime = 3;
                timer.OneShot = true;
                AddChild(timer);
                timer.Start();
                Position = new Vector2(440, 0);
                animationMode = 1;
            }

            if (Position.y < 0) {
                Position = new Vector2(Position.x, Position.y + 200 * delta);
            }
        } else if (animationMode == 2) {
            Position = new Vector2(Position.x, Position.y - 200 * delta);
        }
        base._Process(delta);
    }

    public void Bruh() {
        animationMode = 2;
        Timer timer = new Timer();
        timer.Connect("timeout", this, nameof(Excrutiation));
        timer.WaitTime = 10;
        timer.OneShot = true;
        AddChild(timer);
        timer.Start();
    }

    public void Excrutiation() {
        QueueFree();
    }
}
