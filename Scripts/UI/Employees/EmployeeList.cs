using Godot;
using System;

public class EmployeeList : HBoxContainer {
    public override void _Ready() {
        if (Global.Employees.Count > 0) {
            GetNode<Label>("../../OhNoesIHaveNoEmployees").QueueFree();
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Employee.tscn");

            foreach (var employee in Global.Employees) {
                Employee OK = (Employee)yes.Instance();
                OK.Init(employee.Name, employee.Rating, employee.Salary);
                AddChild(OK);
            }
        }
        base._Ready();
    }
}
