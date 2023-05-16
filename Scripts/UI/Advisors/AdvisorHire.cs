using Godot;
using System;

public class AdvisorHire : TextureButton {
    [Export]
    string AdvisorName = "Bruh Smith";
    Label egjdjhkr;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        egjdjhkr = GetNode<Label>("./Label");
        if (AdvisorName == Global.Advisor) {
            egjdjhkr.Text = "Fire";
        }
    }

    public override void _Process(float delta) {
        // you can only choose 1 advisor
        if (AdvisorName == Global.Advisor) {
            egjdjhkr.Text = "Fire";
        } else {
            egjdjhkr.Text = "Hire";
        }
        base._Process(delta);
    }

    public void Click() {
        if (AdvisorName == Global.Advisor) {
            Global.Advisor = "no one";
            egjdjhkr.Text = "Hire";
        } else {
            Global.Advisor = AdvisorName;
            egjdjhkr.Text = "Fire";
        }
    }
}
