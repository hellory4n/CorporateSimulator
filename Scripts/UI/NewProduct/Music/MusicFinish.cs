using Godot;
using System;

public class MusicFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        // music that's too slow or fast isn't that cool
        switch (Math.Round((decimal)Global.MusicNewProduct.Speed/10)) {
            case 0: Global.MusicNewProduct.Rating += 0; break;
            case 1: Global.MusicNewProduct.Rating += 1; break;
            case 2: Global.MusicNewProduct.Rating += 2; break;
            case 3: Global.MusicNewProduct.Rating += 3; break;
            case 4: Global.MusicNewProduct.Rating += 4; break;
            case 5: Global.MusicNewProduct.Rating += 5; break;
            case 6: Global.MusicNewProduct.Rating += 4; break;
            case 7: Global.MusicNewProduct.Rating += 3; break;
            case 8: Global.MusicNewProduct.Rating += 2; break;
            case 9: Global.MusicNewProduct.Rating += 1; break;
            case 10: Global.MusicNewProduct.Rating += 0; break;
        }

        // the final rating
        Global.MusicNewProduct.Rating += (int)Math.Round((decimal)Global.MusicNewProduct.Melody/40) +
            (int)Math.Round((decimal)Global.MusicNewProduct.Instruments/40);

        Global.MusicNewProduct.Type = "music";
        Global.Money -= Global.MusicNewProduct.MoneySpent;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.MusicNewProduct;
        Global.DevelopingName = Global.MusicNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
