using Godot;
using System;
using System.Collections.Generic;

public class PhoneBatteryButton : TextureButton {
    List<object> ok;

    public void Init(List<object> yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        // index 0 = hours
        // index 1 = rating
        // index 2 = price
        GetNode<Label>("Label").Text = (string)ok[0] + "h - " + (string)ok[1] + "/10 - $"
            + String.Format("{0:n0}", ok[2]);
    }

    public void Click() {
        Global.PhoneNewProduct.Battery = String.Join(",", new string[]{(string)ok[0], (string)ok[1],
            (string)ok[2]});
        GetParent().GetParent().GetParent().QueueFree();
    }
}
