using Godot;
using System;

public class AchievementTest : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/AchievementUnlock.tscn");
        var OK = (AchievementUnlock)yes.Instance();
        OK.Init("Corporate Simulator");
        OK.ZIndex = 420;
        OK.Position = new Vector2(440, -75);
        GetTree().Root.AddChild(OK);
    }
}
