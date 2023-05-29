using Godot;
using System;

public class LabCustomChip : TextureButton {
    int coolPrice = 69420;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        coolPrice = (int)GetNode<Slider>("../Slider1").Value*20 + (int)GetNode<Slider>("../Slider2").Value*2;
        GetNode<Label>("../Fart").Text = $"The chip will cost ${String.Format("{0:n0}", coolPrice)}";
        base._Process(delta);
    }

    public void Click() {
        Product coolChip = new Product();
        int epicRating = (int)GetNode<Slider>("../Slider1").Value/20 + (int)GetNode<Slider>("../Slider2").Value/20;
        coolChip.Rating = epicRating;
        coolChip.MoneySpent = coolPrice;
        coolChip.Name = GetNode<LineEdit>("../ProductName").Text;
        coolChip.ReleaseDate = "Y"+Global.Year + " M"+Global.Month + " W"+Global.Week;
        coolChip.Type = "chip";
        Global.CustomChip.Add(coolChip);
        GetParent().QueueFree();
    }
}
