using Godot;
using System;

public class HumanRelations : Label {
    public override void _Ready() {
        string[] veryFunAndEthicalActivities = {
            "touch grass",
            "do jobs unrelated to the company",
            "use their brain to think of ideas that will give us more money",
            "make a tier list of everything",
            "stop it and get some help",
            "play the famous sport extreme ironing, which combines the mundane task of ironing clothes with extreme outdoor activities",
            "listen to music at unhealthy volumes",
            "work in a very open office, which will definitely make them cooperate more",
            "make epic spreadsheets",
            "make a scientific paper about thermonuclear weapons",
            "tell haha funni jokes",
            "go to a vacation in hawaii for 1 second",
            "buy mugs that have our logo 6,900 times",
        };
        Random eternalExcruciation = new Random();
        Text = $"Hello! I'm Amon Lee Hughman, your advisor. This month I hired 10 employees only because they're minorities (i didn't read their resume) and I forced them to {veryFunAndEthicalActivities[eternalExcruciation.Next(0, veryFunAndEthicalActivities.Length)]}! This is very ethical, fun, and definitely makes our company cooler.";
    }
}
