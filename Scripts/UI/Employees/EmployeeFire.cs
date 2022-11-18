using Godot;
using System;

public class EmployeeFire : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GD.Print("I'M DOING SOMETHIGN!!!!!!!!!!!!!111");
        string employeeName = GetNode<Label>("../EmployeeName").Text;

        for (int i = 0; i < Global.Employees.Count; i++) {
            EmployeeSave onoPerson = Global.Employees[i];
            if (onoPerson.Name == employeeName) {
                Global.Employees.RemoveAt(i);
                GetParent().QueueFree();
                break;
            }
        }
    }
}
