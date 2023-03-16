using Godot;
using System;
using Newtonsoft.Json;

public class RocketBoomText : Label {
    public override void _Ready() {
        // sorry
        Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        Text = $"Your latest rocket, {garbage.Name}, exploded while trying to launch! Please pay ${String.Format("{0:n0}", (long)Global.Money/4)}";
        base._Ready();
    }
}
