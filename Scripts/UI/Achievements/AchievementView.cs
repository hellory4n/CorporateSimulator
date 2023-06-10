using Godot;
using System;

public class AchievementView : Node2D {
    [Export]
    string AchievementName = "AAAAAAAAAAA";

    public override void _Ready() {
        if (Global.Achievements.Achievements[AchievementName]) {
            Texture coolBackground = ResourceLoader.Load<Texture>("res://Assets/AchievementsUnlocked.png");
            GetNode<Sprite>("./Background").Texture = coolBackground;
        } else {
            GetNode<Label>("./Name").AddColorOverride("font_color", new Color(0, 0, 0, 1));
            GetNode<Label>("./Description").AddColorOverride("font_color", new Color(0, 0, 0, 1));
        }
        base._Ready();
    }
}
