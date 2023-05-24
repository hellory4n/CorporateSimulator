using Godot;
using System;

public class LabButton : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        if (Global.LabUnlocked) {
            RectPosition = new Vector2(0, 645);
        } else {
            RectPosition = new Vector2(69420, 69420);
        }
        base._Process(delta);
    }

    public void Click() {
        
    }
}
