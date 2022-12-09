using Godot;
using System;

public class MedicalFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.MedicalNewProduct.Type = "medical";
        Global.Money -= Global.MedicalNewProduct.MoneySpent;
        Global.Investors += Global.MedicalNewProduct.Marketing;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.MedicalNewProduct;
        Global.DevelopingName = Global.MedicalNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
