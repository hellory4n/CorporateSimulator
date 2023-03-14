using Godot;
using System;

public class Back : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.TutorialImage -= 1;
        switch (Global.TutorialImage) {
            case -1:
                File fart = new File();
                fart.Open("user://first_time", File.ModeFlags.Write);
                fart.StoreString("aeiou");
                fart.Close();
                Global.PausedTime = false;
                GetParent().GetParent().QueueFree();
                break;
            default:
                Sprite coolImage = GetNode<Sprite>("../../AwesomeImage");
                coolImage.Texture = ResourceLoader.Load<Texture>($"res://Assets/Tutorial/{Global.TutorialImage+1}.png");
                if (Global.TutorialImage != 0)
                    GetNode<Label>("./Label").Text = "Back";
                else
                    GetNode<Label>("./Label").Text = "Skip";
                break;
        }
    }
}
