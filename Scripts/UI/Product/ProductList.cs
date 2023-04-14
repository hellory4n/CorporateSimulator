using Godot;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;

public class ProductList : HBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Product.tscn");

        if (Global.Products.Count > 0)
            GetNode<Label>("../../OhShoes").QueueFree();

        // we do a reverse for loop so the newest products are shown first
        for (int i = Global.Products.Count - 1; i >= 0 ; i--) {
            object product = Global.Products[i];
            ProductItem OK = (ProductItem)yes.Instance();
            GD.Print(product.ToString());
            // cast doesn't work haha yes
            OK.Init(JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(product)), product);
            AddChild(OK);
        }
        // there's a bug in godot where the last item is out of reach, this hack fixes it
        if (Global.Products.Count > 3) {
            object pain = Global.Products[Global.Products.Count-1];
            ProductItem OK = (ProductItem)yes.Instance();
            // uhhhhhhhhhhh
            OK.Init(JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(pain)), pain);
            AddChild(OK);
        }
        base._Ready();
    }
}
