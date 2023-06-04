using Godot;
using System;

public class ChinaSabotagePay : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public override void _Process(float delta) {
        Slider coolSlider = GetNode<Slider>("../Slider1");
        GetNode<Label>("../Slider1/Label").Text = "$"+String.Format("{0:n0}", coolSlider.Value);
        base._Process(delta);
    }

    public void Click() {
        Global.Money -= (long)GetNode<Slider>("../Slider1").Value;
        Global.China.Friendship -= (int)GetNode<Slider>("../Slider1").Value/100000000;
        GetParent().QueueFree();
    }
}
