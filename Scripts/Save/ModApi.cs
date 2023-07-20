using System;
using Godot;

public class ModApi : Node {
    // this probably means something
    static ModApi instance;
    public static ModApi Instance => instance;

    public void CSButton(Button button, string type="normal", string size="normal", int fontSize=40) {
        DynamicFontData mues = ResourceLoader.Load<DynamicFontData>("res://Uhh/Ubuntu-Bold.ttf");

        // load very epic backgrounds for the button
        StyleBoxTexture normal = new StyleBoxTexture();
        StyleBoxTexture hover = new StyleBoxTexture();
        StyleBoxTexture pressed = new StyleBoxTexture();
        StyleBoxTexture disabled = new StyleBoxTexture();
        
        if (type == "normal" && size == "normal") {
            normal.Texture = ResourceLoader.Load<Texture>("res://Assets/ButtonMenu.png");
            hover.Texture = ResourceLoader.Load<Texture>("res://Assets/HoverButtonMenu.png");
            pressed.Texture = ResourceLoader.Load<Texture>("res://Assets/PressedButtonMenu.png");
        } else if (type == "normal" && size == "small") {
            normal.Texture = ResourceLoader.Load<Texture>("res://Assets/SmallButton.png");
            hover.Texture = ResourceLoader.Load<Texture>("res://Assets/SmallButtonHover.png");
            pressed.Texture = ResourceLoader.Load<Texture>("res://Assets/SmallButtonPressed.png");
        } else if (type == "danger" && size == "normal") {
            normal.Texture = ResourceLoader.Load<Texture>("res://Assets/Danger.png");
            hover.Texture = ResourceLoader.Load<Texture>("res://Assets/DangerHover.png");
            pressed.Texture = ResourceLoader.Load<Texture>("res://Assets/DangerPress.png");
        } else if (type == "danger" && size == "small") {
            normal.Texture = ResourceLoader.Load<Texture>("res://Assets/SmallDanger.png");
            hover.Texture = ResourceLoader.Load<Texture>("res://Assets/SmallDangerHover.png");
            pressed.Texture = ResourceLoader.Load<Texture>("res://Assets/SmallDangerPress.png");
        }
        if (size == "small") {
            disabled.Texture = ResourceLoader.Load<Texture>("res://Assets/SmallDisabledButton.png");
        } else {
            disabled.Texture = ResourceLoader.Load<Texture>("res://Assets/DisabledButton.png");
        }

        // make the cool font
        DynamicFont afont = new DynamicFont();
        afont.FontData = mues;
        afont.Size = fontSize;

        // ye
        button.AddStyleboxOverride("normal", normal);
        button.AddStyleboxOverride("hover", hover);
        button.AddStyleboxOverride("pressed", pressed);
        button.AddStyleboxOverride("disabled", disabled);
        button.AddFontOverride("font", afont);
    }
}