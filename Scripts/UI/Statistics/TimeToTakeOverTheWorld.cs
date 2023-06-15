using Godot;
using System;

public class TimeToTakeOverTheWorld : Label {
    public override void _Ready() {
        Text = $"You took the following time to take over the world:\n{Global.Year+(Global.Month/12)} years\n{(Global.Year*12)+Global.Month} months\n{((Global.Year*12)+Global.Month)*4} weeks\n{(((Global.Year*12)+Global.Month)*4)*7} days";
        base._Ready();
    }
}
