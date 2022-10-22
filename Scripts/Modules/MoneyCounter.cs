using Godot;
using System;

public class MoneyCounter : Node2D {
    DynamicFont font = new DynamicFont();
    Vector2 textPosition;

    public override void _Ready() {
        font.FontData = ResourceLoader.Load<DynamicFontData>("res://Uhh/Ubuntu-Bold.ttf");
        font.Size = 24;
        textPosition = new Vector2(20, 32.5f);
        base._Ready();
    }

    public override void _Draw() {
        DrawString(font, textPosition, "$" + Global.Money.ToString(), new Color(0, 0, 0));
        base._Draw();
    }
}
