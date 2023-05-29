using Godot;
using System;

public class LabCustomConsole : TextureButton {
    int coolPrice = 69420;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        coolPrice = (int)GetNode<Slider>("../Slider1").Value*10 + (int)GetNode<Slider>("../Slider2").Value*10;
        GetNode<Label>("../Fart").Text = $"The console will cost ${String.Format("{0:n0}", coolPrice)}";
        base._Process(delta);
    }

    public void Click() {
        Product coolConsole = new Product();
        int epicRating = (int)GetNode<Slider>("../Slider1").Value/20 + (int)GetNode<Slider>("../Slider2").Value/20;
        coolConsole.Rating = epicRating;
        coolConsole.MoneySpent = coolPrice;
        coolConsole.Name = GetNode<LineEdit>("../ProductName").Text;
        coolConsole.ReleaseDate = "Y"+Global.Year + " M"+Global.Month + " W"+Global.Week;
        coolConsole.Type = "console";
        Global.CustomChip.Add(coolConsole);
        GetParent().QueueFree();
    }
}
