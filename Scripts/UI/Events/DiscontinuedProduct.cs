using Godot;
using System;
using Newtonsoft.Json;

public class DiscontinuedProduct : Label {
    public override void _Ready() {
        // sorry
        Product garbageProduct = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        Text = $"{garbageProduct.Name} is now discontinued. It sold {String.Format("{0:n0}", garbageProduct.Sales)} copies, bringing ${String.Format("{0:n0}", garbageProduct.MoneyGot)} in revenue.";
        base._Ready();
    }
}
