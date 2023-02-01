using Godot;
using System;

public class EnterLottery : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.Money -= 50;
        Random random = new Random();
        if (random.Next(1,1000000) == 1) {
            GetNode<Label>("../Label2").Text = "Somehow, you won!!! Enjoy your easy 20 million dollars";
            Global.Money += 20000000;
        } else {
            GetNode<Label>("../Label2").Text = "You lost, try again next year.";
        }

        GetNode<TextureButton>("../No").RectPosition = new Vector2(440, 575);
        GetNode<Label>("../No/Label").Text = "OK";
        QueueFree();
    }
}