using Godot;
using System;
using Newtonsoft.Json;

public class YourCompanyText : Label {
    public override void _Ready() {
        if (Global.Products.Count > 0) {
            // sorry
            Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
                Global.Products[Global.Products.Count-1]));
            Text = $"Here at {Global.CompanyName} we love mone- I mean customers. We love customers. That is why we built the {garbage.Name}, a really good computer that you should buy immediately. The {garbage.Name} is the start of a new era in computing.";
        } else {
            Text = $"Here at {Global.CompanyName} we didn't make any products but we will soon release the best computer since the [insert best computer ever here].";
        }
        base._Ready();
    }
}
