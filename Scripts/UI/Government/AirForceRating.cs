using Godot;
using System;

public class AirForceRating : Label {
    public override void _Process(float delta) {
        double rating = 0;
        rating += Global.AirForce[0]/100.0;
        rating += Global.AirForce[1]/100.0;
        rating += Global.AirForce[2]/100.0;
        rating += Global.AirForce[3]/100.0;
        rating += Global.AirForce[4]/100.0;
        rating += Global.AirForce[5]/100.0;
        rating += Global.AirForce[6]/100.0;
        rating += Global.AirForce[7]/100.0;
        rating += Global.AirForce[8]/100.0;
        rating += Global.AirForce[9]/100.0;
        Text = $"Air Force: {rating.ToString("0.00")}/10";
        base._Process(delta);
    }
}
