using Godot;
using System;

public class HumanRelationsOK : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        EmployeeSave[] briyjykejggrt = new EmployeeSave[10];
        Random comedy = new Random();
        for (int i = 0; i < briyjykejggrt.Length; i++) {
            briyjykejggrt[i] = new EmployeeSave();
            briyjykejggrt[i].Salary = comedy.Next(1,7) * 1000;
            briyjykejggrt[i].Rating = comedy.Next(10); // nobody is perfect so you can't get a 10/10 rating
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
            briyjykejggrt[i].Name = firstNames[comedy.Next(firstNames.Length)]+" "+lastNames[comedy.Next(firstNames.Length)];
        }
        Global.Employees.AddRange(briyjykejggrt);
        Global.Reputation += 3;

        if (GetNodeOrNull("/root/PauseThingy") != null)
            GetNode("/root/PauseThingy").QueueFree();
        GetParent().QueueFree();
    }
}
