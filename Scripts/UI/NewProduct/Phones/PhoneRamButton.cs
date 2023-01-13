using Godot;
using System;
using System.Collections.Generic;

public class PhoneRamButton : TextureButton {
    List<object> ok;

    public void Init(List<object> yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        // index 0 = capacity
        // index 1 = price
        // index 2 = rating
        GetNode<Label>("Label").Text = (string)ok[0] + " GB - " + (string)ok[2] + "/10 - $"
            + String.Format("{0:n0}", ok[1]);
    }

    public void Click() {
        Global.PhoneNewProduct.Ram = String.Join(",", new string[]{(string)ok[0], (string)ok[1],
            (string)ok[2]});
        GetParent().GetParent().GetParent().QueueFree();
    }
}
