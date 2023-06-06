using Godot;
using System;

public class NavyRating : Label {
    public override void _Process(float delta) {
        double rating = 0;
        rating += Global.Navy[0]/100.0;
        rating += Global.Navy[1]/100.0;
        rating += Global.Navy[2]/100.0;
        rating += Global.Navy[3]/100.0;
        rating += Global.Navy[4]/100.0;
        rating += Global.Navy[5]/100.0;
        rating += Global.Navy[6]/100.0;
        rating += Global.Navy[7]/100.0;
        rating += Global.Navy[8]/100.0;
        rating += Global.Navy[9]/100.0;
        Text = $"Navy: {rating.ToString("0.00")}/10";
        base._Process(delta);
    }
}
