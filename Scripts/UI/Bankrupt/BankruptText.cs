using Godot;
using System;

public class BankruptText : Label {
    public override void _Ready() {
        Text = $"It has been confirmed that {Global.CompanyName}, who was experiencing financial issues lately, has gone bankrupt. Dosney Co. has purchased the remains of the company.";
        base._Ready();
    }
}
