using Godot;
using System;

public class Employee : Control {
    string name = "Joe Mama";
    int rating = 69;
    int salary = 0;

    public void Init(string name_, int rating_, int salary_) {
        name = name_;
        rating = rating_;
        salary = salary_;
    }

    public override void _Ready() {
        GetNode<Label>("EmployeeName").Text = name;
        GetNode<Label>("EmployeeInfo").Text = 
        $"Rating: {rating}/10\nSalary: ${String.Format("{0:n0}", salary)}";
    }
}
