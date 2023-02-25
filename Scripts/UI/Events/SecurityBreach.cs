using Godot;
using System;
using Newtonsoft.Json;

public class SecurityBreach : Label {
    public override void _Ready() {
        // sorry
        Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        string[] exploits = {
            "remotely explode devices",
            "steal the user's precious food",
            "get access to their bank account by analyzing toast information",
            "find the user's exact location and launch a thermonuclear bomb there",
            "do bad things",
            "put viruses in the network that remotely steals coffee and tea"
        };
        Random random = new Random();
        Text = $"Security researchers at the Fartsmellers Organization have discovered a fatal security breach in {Global.CompanyName}'s latest product, {garbage.Name}. This exploit allows hackers {exploits[random.Next(exploits.Length-1)]}. {Global.CompanyName} will pay 10% of their money and update their software.";
        base._Ready();
    }
}
