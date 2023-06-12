using Godot;
using System;

public class ResearchButton : TextureButton {
    ResearchSave ok;

    public void Init(ResearchSave yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        // robert elstem advisor
        if (Global.Advisor != "robert elstem") {
            GetNode<Label>("Label").Text = $"{ok.Name} - {ok.Price}";
        } else {
            GetNode<Label>("Label").Text = $"{ok.Name} - {ok.Price-((int)ok.Price/10)}";
        }
    }

    public void Click() {
        int coolPrice = ok.Price;
        if (Global.Advisor == "robert elstem")
            ok.Price = ok.Price-((int)ok.Price/10);

        if (Global.ResearchPoints >= coolPrice) {
            Global.Researched.Add(ok);
            Global.UnlockedResearch.Remove(ok);
            // robert elstem advisor again
            if (Global.Advisor != "robert elstem") {
                Global.ResearchPoints -= ok.Price;
            } else {
                Global.ResearchPoints -= ok.Price-((int)ok.Price/10);
            }
            // this button is inside a vboxcontainer inside a scrollcontainer inside a node2d
            GetParent().GetParent().GetParent().QueueFree();
        } else {
            GetNode<Label>("Label").Text = "You don't have enough research points!";
        }
    }
}
