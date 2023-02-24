using Godot;
using System;
using Newtonsoft.Json;

public class OffendedText : Label {
    public override void _Ready() {
        Random random = new Random();
        string[] firstNames = {
            "Robert",
            "John",
            "Michael",
            "David",
            "William",
            "Richard",
            "Joseph",
            "Thomas",
            "Charles",
            "Christopher",
            "Daniel",
            "Matthew",
            "Anthony",
            "Mark",
            "Donald",
            "Steven",
            "Paul",
            "Andrew",
            "Joshua",
            "Kenneth",
            "Kevin",
            "Brian",
            "George",
            "Timothy",
            "Mary",
            "Patricia",
            "Jennifer",
            "Linda",
            "Elizabeth",
            "Barbara",
            "Susan",
            "Jessica",
            "Sarah",
            "Karen",
            "Lisa",
            "Nancy",
            "Betty",
            "Margaret",
            "Sandra",
            "Ashley",
            "Kimberly",
            "Emily",
            "Donna",
            "Michelle",
            "Carol",
            "Amanda",
            "Dorothy",
            "Melissa",
            "Deborah"
        };
        string name = firstNames[random.Next(firstNames.Length)];
        // sorry
        Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
            Global.Products[Global.Products.Count-1]));
        Text = $"Hi. I'm {name} {name} from Silly Industries LLC. Your latest product, {garbage.Name}, is deeply offending to me. Pay ${String.Format("{0:n0}", (int)Global.Money/10)} now.\n\nCheers,\n{name} {name}";
        base._Ready();
    }
}
