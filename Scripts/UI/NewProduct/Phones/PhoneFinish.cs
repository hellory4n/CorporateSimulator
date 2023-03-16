using Godot;
using System;

public class PhoneFinish : TextureButton {
    bool gimmicks = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "Gimmicks")
                gimmicks = true;
        }
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.PhoneNewProduct.Type = "phone";
        Global.PhoneNewProduct.ReleaseDate = "Y" + Global.Year + " M" + Global.Month + " W" + Global.Week;
        Global.PhoneNewProduct.MoneySpent = Global.PhoneNewProduct.Price * 5;
        Global.Money -= Global.PhoneNewProduct.MoneySpent;

        // calculate rating
        double notIntRating = 0;
        notIntRating += int.Parse(Global.PhoneNewProduct.Soc.Split(",")[2])/5;
        notIntRating += int.Parse(Global.PhoneNewProduct.Size.Split(",")[1])/5;
        notIntRating += int.Parse(Global.PhoneNewProduct.Ram.Split(",")[2])/5;
        notIntRating += int.Parse(Global.PhoneNewProduct.Storage.Split(",")[1])/5;
        notIntRating += int.Parse(Global.PhoneNewProduct.Battery.Split(",")[1])/5;
        Global.PhoneNewProduct.Rating = (int)Math.Round(notIntRating);

        if (gimmicks)
            Global.PhoneNewProduct.Rating += 2;

        if (Global.PhoneNewProduct.Rating > 10)
            Global.PhoneNewProduct.Rating = 10;

        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.PhoneNewProduct;
        Global.DevelopingName = Global.PhoneNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
