using Godot;
using System;

public class Next : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TutorialImage += 1;
        switch (Global.TutorialImage) {
            case 16:
                File fart = new File();
                fart.Open("user://first_time", File.ModeFlags.Write);
                fart.StoreString("aeiou");
                fart.Close();
                GetParent().GetParent().QueueFree();
                break;
            default:
                if (Global.TutorialImage != 15) {
                    GetNode<Label>("./Label").Text = "Next";
                    GetNode<Label>("../Back/Label").Text = "Back";
                    Sprite coolImage = GetNode<Sprite>("../../AwesomeImage");
                    coolImage.Texture = ResourceLoader.Load<Texture>($"res://Assets/Tutorial/{Global.TutorialImage+1}.png");
                } else {
                    GetNode<Label>("./Label").Text = "Done";
                    GetNode<TextureButton>("../Back").QueueFree();
                    RectPosition = new Vector2(290, 440);
                }
                break;
        }
    }
}
