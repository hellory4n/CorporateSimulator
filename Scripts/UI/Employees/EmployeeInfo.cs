using Godot;
using System;

public class EmployeeInfo : Label {
    public override void _Ready() {
        Random randomlyRandom = new Random();
        int rating = randomlyRandom.Next(10);
        int salary = randomlyRandom.Next(1, 7) * 1000;
        Text = $"Rating: {rating}/10\nSalary: ${String.Format("{0:n0}", salary)}";
        Global.Garbage1 = rating;
        Global.Garbage2 = salary;
    }
}
