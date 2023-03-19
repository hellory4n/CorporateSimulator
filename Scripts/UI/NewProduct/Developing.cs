using Godot;
using System;

public class Developing : Label {
    int waitTime = 60;

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
        waitTime = 60/Global.TimeSpeed;

        // so you can hire employees in the middle of development and it'll affect something
        foreach (var idiot in Global.Employees) {
            if (idiot.Rating > 0)
                waitTime -= (int)idiot.Rating/2;
        }
        if (waitTime < 1)
            waitTime = 1;

        if (Engine.GetIdleFrames() % (ulong)waitTime == 0 && Global.PausedTime == false) {
            Global.DevelopingProgress++;
            Text = "Developing " + Global.DevelopingName + ": " + Global.DevelopingProgress + "%";
        }

        if (Global.DevelopingProgress == 100) {
            Global.Products.Add(Global.Developing);

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

            Global.ResearchPoints += 10 * Global.Year;
            Global.Developing = null;
            QueueFree();
            Global.DevelopingProgress = 0;
        }

        base._Process(delta);
    }
}