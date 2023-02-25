using Godot;
using System;
using Newtonsoft.Json;

public class MessagingAppDisease : Label {
    public override void _Ready() {
        // sorry
        Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        Text = $"Hello. I am Christopher James Steven John Peter Alex Mike Timothy Explosions the Third from the United States Department of Agriculture. We have found that your latest food, {garbage.Name}, has a 69% chance of giving people Messaging App Disease. As such, pay ${String.Format("{0:n0}", (int)Global.Money/4)} or your reputation will be much worse.\n\nCheers,\nChristopher James Steven John Peter Alex Mike Timothy Explosions the Third";
        base._Ready();
    }
}
