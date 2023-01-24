using Godot;
using System;

public class PublicRelations : Node2D {
    public override void _Ready() {
        GetNode<Label>("Review").Text = Global.CompanyName;
        string[] reviews = {"m", "p", "r", "h"};

        // reviewers
        string[] firstNames = {
            "James",
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
        string[] lastNames = {
            "Smith",
            "Johnson",
            "Williams",
            "Brown",
            "Jones",
            "Garcia",
            "Miller",
            "Davis",
            "Rodriguez",
            "Martinez",
            "Hernandez",
            "Lopez",
            "Gonzalez",
            "Wilson",
            "Anderson",
            "Thomas",
            "Taylor",
            "Moore",
            "Jackson",
            "Martin",
            "Lee",
            "Perez",
            "Thompson",
            "White",
            "Harris",
            "Sanchez",
            "Clark",
            "Ramirez",
            "Lewis",
            "Robinson",
            "Walker",
            "Young",
            "Allen",
            "King",
            "Wright",
            "Scott",
            "Torres",
            "Nguyen",
            "Hill",
            "Flores",
            "Green",
            "Adams",
            "Nelson",
            "Baker",
            "Hall",
            "Rivera",
            "Campbell",
            "Mitchell",
            "Carter",
            "Roberts"
        };
        Random random = new Random();
        string[] reviewers = {
            firstNames[random.Next(0,50)] + " " + lastNames[random.Next(0,50)],
            firstNames[random.Next(0,50)] + " " + lastNames[random.Next(0,50)],
            firstNames[random.Next(0,50)] + " " + lastNames[random.Next(0,50)],
            firstNames[random.Next(0,50)] + " " + lastNames[random.Next(0,50)]
        };

        // reviews
        if (Global.Reputation < 25)
            reviews = new string[]{"This company is bad :(", "I would rather use Doors Vision",
            "They will take over the world", "Worst company since Digital Arts"};
        if (Global.Reputation < 50 && Global.Reputation > 25)
            reviews = new string[]{"it's definitely a company", "Their products suck", "I hate this company >:(",
            "Stop it, get some help"};
        if (Global.Reputation < 95 && Global.Reputation > 50)
            reviews = new string[]{"Cool company", "Their products are very good and definitely not overpriced",
            "I highly recommend you give them money", "Great company"};
        if (Global.Reputation < 101 && Global.Reputation > 95)
            reviews = new string[]{"Best company ever", Global.CeoName + " is a genius", "They make masterpieces",
            "I love giving them all of my hard-earned cash!"};

        for (int i = 1; i < 5; i++) {
            GetNode<Label>("Rating"+i).Text = Math.Round((decimal)Global.Reputation/10).ToString();
            GetNode<Label>("Reviewer"+i).Text = reviewers[i-1];
            GetNode<Label>("Review"+i).Text = reviews[i-1];
        }
        base._Ready();
    }
}
