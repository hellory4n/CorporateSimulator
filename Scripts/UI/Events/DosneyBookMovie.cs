using Godot;
using System;
using Newtonsoft.Json;

public class DosneyBookMovie : Label {
    public override void _Ready() {
        // uh
        Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        Text = $"Hi, I'm from Dosney, and we would like to make a movie version for {garbage.Name}. We will give $50M if you accept!";
        base._Ready();
    }
}
