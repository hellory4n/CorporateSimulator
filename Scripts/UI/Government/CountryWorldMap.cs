using Godot;
using System;

public class CountryWorldMap : Sprite {
    [Export]
    string Country = "bhffsfh";

    public override void _Ready() {
        if (Global.Invaded.Contains(Country)) {
            Modulate = new Color(0.242f, 0.726f, 0.285f);
        }
        base._Ready();
    }
}
