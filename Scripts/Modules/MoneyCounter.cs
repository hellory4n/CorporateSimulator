using Godot;
using System;

public class MoneyCounter : Node2D {
    // why didn't i just use a label
    DynamicFont font = new DynamicFont();
    Vector2 textPosition;
    string stupidity = Global.Money.ToString();

    public override void _Ready() {
        font.FontData = ResourceLoader.Load<DynamicFontData>("res://Uhh/Ubuntu-Bold.ttf");
        font.Size = 24;
        textPosition = new Vector2(60, 32.5f);
        base._Ready();
    }

    public override void _Process(float delta) {
        stupidity = Global.Money.ToString();
        // _Draw() is only called once, but we don't want that, so we do this
        Update();
        base._Process(delta);
    }

    public override void _Draw() {
        if (stupidity.StartsWith("69") || stupidity.StartsWith("420") || stupidity.StartsWith("69420")) {
            DrawString(font, textPosition, "$"+String.Format("{0:n0}", Global.Money)+" (nice)", new Color(0, 0, 0));
        } else {
            DrawString(font, textPosition, "$"+String.Format("{0:n0}", Global.Money), new Color(0, 0, 0));
        }
        base._Draw();
    }
}
