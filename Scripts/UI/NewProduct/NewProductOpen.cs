using Godot;
using System;

public class NewProductOpen : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (Global.Employees.Count > 0) {
            switch (Global.Industries[0]) {
                case "space":
                    var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Space.tscn");
                    Node2D OK = (Node2D)yes.Instance();
                    OK.ZIndex = 100;
                    GetTree().Root.AddChild(OK);
                    break;
                case "books":
                    var yesbook = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Book.tscn");
                    Node2D OKbook = (Node2D)yesbook.Instance();
                    OKbook.ZIndex = 100;
                    GetTree().Root.AddChild(OKbook);
                    break;
                case "medical":
                    var yesmedical = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Medical.tscn");
                    Node2D OKmedical = (Node2D)yesmedical.Instance();
                    OKmedical.ZIndex = 100;
                    GetTree().Root.AddChild(OKmedical);
                    break;
                case "computers":
                    var yespc = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Computer.tscn");
                    Node2D OKpc = (Node2D)yespc.Instance();
                    OKpc.ZIndex = 100;
                    GetTree().Root.AddChild(OKpc);
                    break;
                case "music":
                    var yesmoosic = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Music.tscn");
                    Node2D OKmoosic = (Node2D)yesmoosic.Instance();
                    OKmoosic.ZIndex = 100;
                    GetTree().Root.AddChild(OKmoosic);
                    break;
                case "media":
                    var yesmedia = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Media.tscn");
                    Node2D OKmedia = (Node2D)yesmedia.Instance();
                    OKmedia.ZIndex = 100;
                    GetTree().Root.AddChild(OKmedia);
                    break;
                case "food":
                    var yesfood = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Food.tscn");
                    Node2D OKfood = (Node2D)yesfood.Instance();
                    OKfood.ZIndex = 100;
                    GetTree().Root.AddChild(OKfood);
                    break;
            }
        } else {
            GetNode<Label>("Label").Text = "You have no employees!";
        }
    }
}
