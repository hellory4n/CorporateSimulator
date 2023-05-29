using Godot;
using System;

public class LabResearch : TextureButton {
    [Export]
    string Project = "bruh.com™";
    [Export]
    long TotalCost = 694201337;

    public override void _Ready() {
        // shows things in the correct industry
        switch (Global.Industries[0]) {
            case "computers":
                if (Project != "custom os computer" && Project != "custom chip computer" && Project !=
                "make a government" && Project != "obnoxious ads" && Project != "ultra overpriced products"
                && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "food":
                if (Project != "lab food" && Project != "food made of plastic" && Project !=
                "food that lasts beyond forever" && Project != "make a government" && Project !=
                "obnoxious ads" && Project != "ultra overpriced products"
                && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "books":
                if (Project != "epic covers" && Project != "make a government" && Project != "obnoxious ads"
                && Project != "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "tv":
                if (Project != "4d camera" && Project != "make a government" && Project != "obnoxious ads" &&
                Project != "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "medical":
                if (Project != "make a government" && Project != "obnoxious ads" && Project !=
                "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "electronics": // appliances, when i made the industry system i didn't know the name in english lol
                if (Project != "ridiculous gimmicks" && Project != "make a government" && Project !=
                "obnoxious ads" && Project != "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "apps":
                if (Project != "4d ui" && Project != "quantum algorithm" && Project != "make a government" &&
                Project != "obnoxious ads" && Project != "ultra overpriced products" && Project !=
                "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "music":
                if (Project != "short form music" && Project != "make a government" && Project != "obnoxious ads"
                && Project != "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "phones":
                if (Project != "custom os phone" && Project != "custom chip phone" && Project !=
                "make a government" && Project != "obnoxious ads" && Project != "ultra overpriced products"
                && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "media":
                if (Project != "4d camera" && Project != "make a government" && Project != "obnoxious ads" &&
                Project != "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "yourarse": // ourtube
                if (Project != "4d camera" && Project != "endless sponsorships" && Project != "next-level clickbait" 
                && Project != "make a government" && Project != "obnoxious ads" && Project !=
                "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "games":
                if (Project != "custom console" && Project != "quantum 4d gameplay" && Project !=
                "quantum 4d graphics" && Project != "make a government" && Project != "obnoxious ads" && Project
                != "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
            case "space":
                if (Project != "make a government" && Project != "obnoxious ads" && Project !=
                "ultra overpriced products" && Project != "celebrity endorsements") {
                    GetParent().QueueFree();
                }
                break;
        }
        // why would you research governments twice, you don't want to create your very own civil war
        if (Global.LabResearch.Contains(Project) && Project != "custom console" && Project != "custom os phone"
        && Project != "custom chip phone" && Project != "custom os computer" && Project != "custom chip computer") {
            GetParent().QueueFree();
        }
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        Global.LabCurrentProject = Project;
        Global.LabThingsToSpend = TotalCost;
        Global.LabTotalCost = TotalCost;

        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Lab/CustomOS.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);

        // uh
        GetParent().GetParent().GetParent().GetParent().QueueFree();
    }
}
