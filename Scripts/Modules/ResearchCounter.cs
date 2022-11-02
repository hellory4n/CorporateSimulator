using Godot;
using System;

public class ResearchCounter : Node2D {
    DynamicFont font = new DynamicFont();
    Vector2 textPosition;

    public override void _Ready() {
        font.FontData = ResourceLoader.Load<DynamicFontData>("res://Uhh/Ubuntu-Bold.ttf");
        font.Size = 24;
        textPosition = new Vector2(60, 35);
        base._Ready();
    }

    public override void _Process(float delta) {
        // _Draw() is only called once, but we don't want that, so we do this
        Update();
        base._Process(delta);
    }

    public override void _Draw() {
        DrawString(font, textPosition, String.Format("{0:n0}", Global.ResearchPoints), new Color(0, 0, 0));
        base._Draw();
    }
}
