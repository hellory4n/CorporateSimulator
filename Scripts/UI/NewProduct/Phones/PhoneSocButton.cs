using Godot;
using System;
using System.Collections.Generic;

public class PhoneSocButton : TextureButton {
    List<object> ok;

    public void Init(List<object> yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        // index 0 = brand
        // index 1 = model
        // index 2 = rating
        // index 3 = price
        GetNode<Label>("Label").Text = (string)ok[0] + " " + (string)ok[1] + " - " + (string)ok[2] + "/10 - $"
            + String.Format("{0:n0}", ok[3]);
    }

    public void Click() {
        Global.PhoneNewProduct.Soc = String.Join(",", new string[]{(string)ok[0], (string)ok[1],
            (string)ok[2], (string)ok[3]});
        GetParent().GetParent().GetParent().QueueFree();
    }
}
