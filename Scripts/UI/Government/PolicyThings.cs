using Godot;
using System;

public class PolicyThings : TextureButton {
    string[] lawsAndPolicies = new string[] {
        "You can't mock the great leader of " + Global.CountryName,
        "Make a very cool educational system",
        "Everyone over the age of 18 can vote, but the elections only have one option (you)",
        "You can't smoke in public areas, that's not cool.",
        "Invent healthcare",
        "Employers have to pay people",
        "Give people vaccines",
        "Invent public transportation",
        "Make epic houses and stuff",
        "Invent copyright law",
        "Workers can get 6 month vacations twice a year",
        "Companies can't give customers a middle finger",
        "Make very sciency things",
        "Make very cool parks",
        "Create very epic infrastructure",
        "Make climate change illegal",
        "Make stuff to protect mental healthcare and stuff so citizens don't explode",
        "Everyone has to speak spanish in April 1st to confuse foreigners",
        "Give citizens rocks that are pets",
        "Make a social program for giving ice cream",
        "Prohibit eating pizza with a fork and knife, use your hands",
        "It is illegal to take oneself too seriously; humor is a constitutional right.",
        "Sneezing without saying 'Bless you' is considered a criminal offense.",
        "The official language for conversations about the weather is Albanian.",
        "Talking to plants is encouraged, as they hold valuable gardening advice.",
        "Snowball fights are allowed only in the summer months.",
        "Use of the word 'good' followed by 'luck' is banned to avoid excessive luck.",
        "Haircuts must be approved by the Federal Department of Haircuts hosted in the national capital",
        "Tea/coffee time is an official government-mandated break every afternoon.",
        "You must use emojis in serious e-mails.",
        "Telling bad jokes in elevators is punishable by tickling.",
        "The national anthem is some classical music along with the phrase \"" + Global.CountryName + " is very epic\" said 69 times",
        "Rename the wireless mouse to hamster",
        Global.CountryName + " is a nation that can be defined in a single word: awdsmfafoothimaaafootafootwhscuseme.",
        "The minister of education must always be the great leader's pet"
    };

    public override void _Ready() {
        Random h = new Random();
        GetNode<Label>("../Law").Text = lawsAndPolicies[h.Next(0, lawsAndPolicies.Length)];
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Random h = new Random();
        GetNode<Label>("../Law").Text = lawsAndPolicies[h.Next(0, lawsAndPolicies.Length)];
    }
}
