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
            // there's a bug in godot where the last item is out of reach, this fixes it
            if (Global.Employees.Count > 3) {
                Control suffer = new Control();
                AddChild(suffer);
            }
        }
        base._Ready();
    }
}
