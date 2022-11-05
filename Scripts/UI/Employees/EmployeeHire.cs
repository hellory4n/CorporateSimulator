using Godot;
using System;

public class EmployeeHire : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        // hire
        EmployeeSave ben = new EmployeeSave();
        ben.Name = GetNode<Label>("../EmployeeName").Text;
        ben.Rating = Global.Garbage1;
        ben.Salary = Global.Garbage2;
        Global.Employees.Add(ben);

        GetParent().QueueFree();
    }
}
