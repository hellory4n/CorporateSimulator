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
            }
        } else {
            GetNode<Label>("Label").Text = "You have no employees!";
        }
    }
}
