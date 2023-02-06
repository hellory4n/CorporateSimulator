using Godot;
using System;
using Newtonsoft.Json;

public class BadMedicalThingText : Label {
    public override void _Ready() {
        // uh
        Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        Text = $"Your latest medical product, {garbage.Name}, was so bad that you have to pay ${String.Format("{0:n0}", (long)Global.Money/4)}";
        base._Ready();
    }
}
