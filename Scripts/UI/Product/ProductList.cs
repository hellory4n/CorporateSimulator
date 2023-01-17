using Godot;
using System;
using Newtonsoft.Json;

public class ProductList : HBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Product.tscn");

        if (Global.Products.Count > 0)
            GetNode<Label>("../../OhShoes").QueueFree();

        foreach (var product in Global.Products) {
            ProductItem OK = (ProductItem)yes.Instance();
            GD.Print(product.ToString());
            // cast doesn't work haha yes
            OK.Init(JsonConvert.DeserializeObject<Product>(product.ToString()), product);
            AddChild(OK);
        }
        // there's a bug in godot where the last item is out of reach, this hack fixes it
        if (Global.Products.Count > 3) {
            object pain = Global.Products[Global.Products.Count-1];
            ProductItem OK = (ProductItem)yes.Instance();
            // uhhhhhhhhhhh
            OK.Init(JsonConvert.DeserializeObject<Product>(pain.ToString()), pain);
            AddChild(OK);
        }
        base._Ready();
    }
}
