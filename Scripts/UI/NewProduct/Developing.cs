using Godot;
using System;

public class Developing : Label {
    int waitTime = 30;

    public override void _Ready() {
        Text = "Developing " + Global.DevelopingName + ": 0%";
        foreach (var idiot in Global.Employees) {
            if (idiot.Rating > 0)
                waitTime -= (int)idiot.Rating/2;
        }
        if (waitTime < 1)
            waitTime = 1;
        GD.Print(waitTime);
    }

    public override void _Process(float delta) {
        if (Engine.GetIdleFrames() % (ulong)waitTime == 0 && Global.PausedTime == false) {
            Global.DevelopingProgress++;
            Text = "Developing " + Global.DevelopingName + ": " + Global.DevelopingProgress + "%";
        }

        if (Global.DevelopingProgress == 100) {
            if (Global.Developing is SpaceProduct)
                Global.Products.Add(Global.SpaceNewProduct);
            if (Global.Developing is BookProduct)
                Global.Products.Add(Global.BookNewProduct);
            if (Global.Developing is MedicalProduct)
                Global.Products.Add(Global.MedicalNewProduct);
            if (Global.Developing is ComputerProduct)
                Global.Products.Add(Global.ComputerNewProduct);
            if (Global.Developing is MusicProduct)
                Global.Products.Add(Global.MusicNewProduct);
            if (Global.Developing is MediaProduct)
                Global.Products.Add(Global.MediaNewProduct);
            if (Global.Developing is FoodProduct)
                Global.Products.Add(Global.FoodNewProduct);
            if (Global.Developing is TvProduct)
                Global.Products.Add(Global.TvNewProduct);
            if (Global.Developing is ElectronicsProduct)
                Global.Products.Add(Global.ElectronicsNewProduct);
            if (Global.Developing is AppProduct)
                Global.Products.Add(Global.AppNewProduct);
            if (Global.Developing is PhoneProduct)
                Global.Products.Add(Global.PhoneNewProduct);
            if (Global.Developing is YourArseProduct)
                Global.Products.Add(Global.YourArseNewProduct);

            Global.SpaceNewProduct = new SpaceProduct();
            Global.BookNewProduct = new BookProduct();
            Global.MedicalNewProduct = new MedicalProduct();
            Global.ComputerNewProduct = new ComputerProduct();
            Global.MusicNewProduct = new MusicProduct();
            Global.MediaNewProduct = new MediaProduct();
            Global.FoodNewProduct = new FoodProduct();
            Global.TvNewProduct = new TvProduct();
            Global.ElectronicsNewProduct = new ElectronicsProduct();
            Global.AppNewProduct = new AppProduct();
            Global.PhoneNewProduct = new PhoneProduct();
            Global.YourArseNewProduct = new YourArseProduct();

            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("review", "Reviews");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);

            Global.ResearchPoints += 10;
            Global.Developing = null;
            QueueFree();
            Global.DevelopingProgress = 0;
        }

        base._Process(delta);
    }
}