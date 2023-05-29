using Godot;
using System;

public class AgreeToLegalStuff : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        File fart = new File();
        fart.Open("user://legal_stuff", File.ModeFlags.Write);
        fart.StoreString("this user has definitely agreed to the license and privacy policy and definitely agrees with what it says");
        fart.Close();
        GetParent().QueueFree();
    }
}
