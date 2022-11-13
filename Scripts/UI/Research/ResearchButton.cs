using Godot;
using System;

public class ResearchButton : TextureButton {
    ResearchSave ok;

    public void Init(ResearchSave yeah) {
        ok = yeah; // you're welcome
    }

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        GetNode<Label>("Label").Text = $"{ok.Name} - {ok.Price}";
    }

    public void Click() {
        if (Global.ResearchPoints >= ok.Price) {
            Global.Researched.Add(ok);
            Global.UnlockedResearch.Remove(ok);
            Global.ResearchPoints -= ok.Price;
            // this button is inside a vboxcontainer inside a scrollcontainer inside a node2d
            GetParent().GetParent().GetParent().QueueFree();
        } else {
            GetNode<Label>("Label").Text = "You don't have enough research points!";
        }
    }
}
