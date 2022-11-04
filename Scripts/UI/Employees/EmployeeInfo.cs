using Godot;
using System;

public class EmployeeInfo : Label {
    public override void _Ready() {
        Random randomlyRandom = new Random();
        Text = "Rating: " + randomlyRandom.Next(10) + "/10\nSalary: $" +
        String.Format("{0:n0}", randomlyRandom.Next(1, 5) * 1000);
    }
}
