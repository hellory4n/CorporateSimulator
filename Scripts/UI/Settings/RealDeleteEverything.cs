using Godot;
using System;

public class RealDeleteEverything : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Directory fart = new Directory(); // yes.
        File farted = new File();
        if (farted.FileExists("user://settings.json"))
            fart.Remove("user://settings.json");
        if (farted.FileExists("user://first_time"))
            fart.Remove("user://first_time");
        if (farted.FileExists("user://game1.json"))
            fart.Remove("user://game1.json");
        if (farted.FileExists("user://game2.json"))
            fart.Remove("user://game2.json");
        if (farted.FileExists("user://game3.json"))
            fart.Remove("user://game3.json");
        if (farted.FileExists("user://game4.json"))
            fart.Remove("user://game4.json");
        if (farted.FileExists("user://game5.json"))
            fart.Remove("user://game5.json");
        if (farted.FileExists("user://game6.json"))
            fart.Remove("user://game6.json");
        if (farted.FileExists("user://game7.json"))
            fart.Remove("user://game7.json");
        if (farted.FileExists("user://game8.json"))
            fart.Remove("user://game8.json");
        
        GetTree().Quit();
    }
}
