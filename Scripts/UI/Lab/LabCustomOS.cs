using Godot;
using System;

public class LabCustomOS : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Product coolOS = new Product();
        int epicRating = (int)GetNode<Slider>("../Slider1").Value/20 + (int)GetNode<Slider>("../Slider2").Value/20;
        coolOS.Rating = epicRating;
        coolOS.MoneySpent = 500000000;
        coolOS.Name = GetNode<LineEdit>("../ProductName").Text;
        coolOS.ReleaseDate = "Y"+Global.Year + " M"+Global.Month + "W"+Global.Week;
        coolOS.Type = "os";
        Global.CustomOS.Add(coolOS);
        GetParent().QueueFree();
    }
}
