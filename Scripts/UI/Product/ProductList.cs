using Godot;
using System;

public class ProductList : HBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Product.tscn");

        foreach (var product in Global.Products) {
            ProductItem OK = (ProductItem)yes.Instance();
            OK.Init(product as Product);
            AddChild(OK);
        }
        // there's a bug in godot where the last item is out of reach, this hack fixes it
        if (Global.Products.Count > 3) {
            object pain = Global.Products[Global.Products.Count-1];
            ProductItem OK = (ProductItem)yes.Instance();
            OK.Init((Product)pain);
            AddChild(OK);
        }
        base._Ready();
    }
}
