using Godot;
using System;

public class EmployeeFire : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        string employeeName = GetNode<Label>("../EmployeeName").Text;
        foreach (var onoPerson in Global.Employees) {
            if (onoPerson.Name == employeeName)
                Global.Employees.Remove(onoPerson);
                break;
        }
    }
}
