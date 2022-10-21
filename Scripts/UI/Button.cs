using Godot;
using System;

public class Button : Node2D {
    [Export]
    public string ButtonType;
    [Export]
    public string ButtonText;
    [Export(PropertyHint.File)]
    public string SceneToOpen;
    [Export]
    public string textAlign;
    public Vector2 pos;
    DynamicFont font = new DynamicFont();
    Vector2 textPosition;
    Vector2 rightBottom;

    public void Init(string type, string text, string scene, string textAlign, Vector2 _position) {
        ButtonType = "res://Assets/Button" + type + ".png";
        ButtonText = text;
        SceneToOpen = "res://Scenes/" + scene + ".tscn";
        pos = _position; // you're welcome
        rightBottom = new Vector2(pos.x+400, pos.y+75);
    }

    public override void _Ready() {
        // Load button sprite and stuff
        Texture texture = ResourceLoader.Load<Texture>(ButtonType);
        Sprite sprite = new Sprite();
        sprite.Texture = texture;
        sprite.ZIndex = -1;
        sprite.Position = pos;
        sprite.Centered = false;
        this.AddChild(sprite);
        this.Position = pos; // you're welcome²
        font.FontData = ResourceLoader.Load<DynamicFontData>("res://Uhh/Ubuntu-Bold.ttf");
        font.Size = 40;
        textPosition = new Vector2(
            pos.x+font.GetStringSize(ButtonText).x/5+font.GetAscent(),
            pos.y+font.GetStringSize(ButtonText).y/4+font.GetAscent()
        );
    }

    public override void _Process(float delta) {
        // Click
        // Why i made my own button thing
        Vector2 mousePosition = GetViewport().GetMousePosition();
        if (mousePosition > pos && mousePosition < rightBottom) {
            if (Input.IsActionJustReleased("click")) {
                var yes = (PackedScene)ResourceLoader.Load("res://Scenes/GodotSpriteToTestTheButton.tscn");
                Node2D OK = (Node2D)yes.Instance();
                GetTree().Root.AddChild(OK);
            }
        }

        base._Process(delta);
    }

    public override void _Draw() {
        DrawString(font, textPosition, ButtonText);
        base._Draw();
    }
}
