using Godot;
using System;

public class ArmyRating : Label {
    public override void _Process(float delta) {
        double rating = 0;
        rating += Global.Army[0]/100.0;
        rating += Global.Army[1]/100.0;
        rating += Global.Army[2]/100.0;
        rating += Global.Army[3]/100.0;
        rating += Global.Army[4]/100.0;
        rating += Global.Army[5]/100.0;
        rating += Global.Army[6]/100.0;
        rating += Global.Army[7]/100.0;
        rating += Global.Army[8]/100.0;
        rating += Global.Army[9]/100.0;
        GD.Print($"rating: {rating}");
        Text = $"Army: {rating.ToString()}/10";
        base._Process(delta);
    }
}
