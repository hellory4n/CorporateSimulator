using Godot;
using System;

public class ComputerFinish : TextureButton {
    bool rgb = false;
    bool upgradability = false;

    public override void _Ready() {
        // if we add this on the process function the game would run at 0 fps
        foreach (var item in Global.Researched) {
            if (item.Name == "RGB lights")
                rgb = true;
            if (item.Name == "Upgradability")
                upgradability = true;
        }
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.ComputerNewProduct.Type = "computer";
        Global.ComputerNewProduct.ReleaseDate = "Y" + Global.Year + " M" + Global.Month + " W" + Global.Week;
        Global.ComputerNewProduct.MoneySpent = Global.ComputerNewProduct.Price * 5;
        Global.Money -= Global.ComputerNewProduct.MoneySpent;

        // calculate rating
        double notIntRating = 0;
        notIntRating += int.Parse(Global.ComputerNewProduct.Cpu.Split(",")[2])/5;
        notIntRating += int.Parse(Global.ComputerNewProduct.Gpu.Split(",")[2])/5;
        notIntRating += int.Parse(Global.ComputerNewProduct.Ram.Split(",")[2])/5;
        notIntRating += int.Parse(Global.ComputerNewProduct.Storage.Split(",")[2])/5;
        notIntRating += int.Parse(Global.ComputerNewProduct.Os.Split(",")[2])/5;
        Global.ComputerNewProduct.Rating = (int)Math.Round(notIntRating);

        if (rgb)
            Global.ComputerNewProduct.Rating += 1;
        
        if (upgradability)
            Global.ComputerNewProduct.Rating += 1;

        if (Global.ComputerNewProduct.Rating > 10)
            Global.ComputerNewProduct.Rating = 10;

        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.ComputerNewProduct;
        Global.DevelopingName = Global.ComputerNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
