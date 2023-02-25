using Godot;
using System;
using Newtonsoft.Json;

public class Boom : Label {
    public override void _Ready() {
        // sorry
        Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        Text = $"Hi, I'm James James III (son of the president James James II). I'm one of the users that used the new {garbage.Name} and saw it exploding. Please fix it and pay us ${String.Format("{0:n0}", (int)Global.Money/10)} or my dad will explode your company.\n\nCheers,\nJames James III";
        base._Ready();
    }
}
