using Godot;
using System;

public class PoliticsLol : Label {
    public override void _Ready() {
        string[] majesticQuotes = {
            "i'm gonna make america great again",
            "wow we have some awesome nukes",
            "MURICA FORK YEAH",
            "freedom is the only way",
            "i'm gonna nuke the terrorists",
            "Donald (fast-food)",
            "i love printing money",
            "we need to build the wall",
            "there are at least 3 genders",
            "I will be phenomenal to the women. I mean, I want to help women.",
            "as a wise mexican once said, \"eu quero um taco bell\"",
            "The concept of global warming was created by and for the Chinese in order to make U.S. manufacturing non-competitive.",
            "If you look at Haddam Sussein, he killed terrorists. I'm not saying he was an angel, but this guy killed terrorists.",
            "If Justin Case can't satisfy his wife what makes he think he can satisfy America?"
        };
        Random random = new Random();
        Text = "President James James II was elected for the "+(Global.Year/4+1)+"th time with 69% of the votes.\n\""+
        majesticQuotes[random.Next(0, majesticQuotes.Length)] + "\" - James James II during a speech";
        base._Ready();
    }
}
