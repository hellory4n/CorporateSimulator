using Godot;
using System;

public class ElectronicsFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.ElectronicsNewProduct.Type = "electronics";
        Global.ElectronicsNewProduct.ReleaseDate = "Y" + Global.Year + " M" + Global.Month + " W" + Global.Week;
        Global.Money -= Global.ElectronicsNewProduct.MoneySpent;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.ElectronicsNewProduct;
        Global.DevelopingName = Global.ElectronicsNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
