using Godot;
using System;

public class FoodFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.FoodNewProduct.Type = "food";
        Global.FoodNewProduct.ReleaseDate = "Y" + Global.Year + " M" + Global.Month + " W" + Global.Week;
        Global.Money -= Global.FoodNewProduct.MoneySpent;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.FoodNewProduct;
        Global.DevelopingName = Global.FoodNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
