using Godot;
using System;

public class CompetitionText : Label {
    public override void _Ready() {
        switch (Global.Industries[0]) {
            case "space":
                Text = "NOSE: $600,000,000,000\nSpaceZ: $137,000,000,000\nRed Origin: $69,000,000,000\n" +
                "Epic Galaxies: $34,000,000,000";
                break;
            case "books":
                Text = "Penguin Books: $4,000,000,000\nEpic Book Co: $2,000,000,000\nReadable Books: " +
                "$1,000,000,000";
                break;
            case "medical":
                Text = "James & James: $400,000,000,000\nRock: $300,000,000,000\nPfiner: $210,000,000,000\n"+
                "Elephant: $200,000,000,000";
                break;
            case "computers":
                Text = "Legend: $200,000,000,000\nHD: $175,000,000,000\nDelete: $150,000,000,000\nPineapple: "+
                "$125,000,000,000\nIce: $100,000,000,000\nASUSTAINABLE: $75,000,000,000\nMacrohard: "+
                "$50,000,000,000\nToshibanana: $25,000,000,000\nSam's Song: $10,000,000,000\nMY: $1,000,000,000";
                break;
            case "music":
                Text = "Sonia Music: $50,000,000,000\nUniverse Music: $25,000,000,000\nWarning: $12,000,000,000\n"+
                "Coal: $6,000,000,000\nStrong Music: $3,000,000,000\nPencil Music: $1,000,000,000\nBen Music: "+
                "$500,000,000\nWidget Music: $250,000,000\nChicken Music: $125,000,000\nMusic Door: $60,000,000";
                break;
            case "media":
                Text = "Universe: $30,000,000,000\nGlobal Mountains: $15,000,000,000\nWarning Bros: $7,000,000,000\n"+
                "Dosney: $3,000,000,000\nSonia Pictures: $1,000,000,000";
                break;
            case "food":
                Text = "No's Ten: $90,000,000,000\nAdministrator: $45,000,000,000\nWilliam: $23,000,000,000\nSysservitems: "+
                "$11,000,000,000\nJohn Meat: $5,000,000,000\nGeorge Co: $1,000,000,000\nTasty: $500,000,000\nDayesne: $250,000,000\n"+
                "Purchase: $125,000,000\nDelicious World: $60,000,000";
                break;
            case "tv":
                Text = "JRG: $10,000,000,000\nTJH: $5,000,000,000\nSLT: $2,000,000,000\nAnimals: $1,000,000,000\nAnimal News: "+
                "$500,000,000\nJROE: $250,000,000\nYITJH: $125,000,000\nIEY: $60,000,000\nHUOG: $30,000,00\nGalaxy: $15,000,000";
                break;
            case "electronics":
                Text = "Wow: $50,000,000,000\nLS: $25,000,000,000\nSam's Song: $12,000,000,000\nKitchens: $6,000,000,000\nApply: "+
                "$3,000,000,000";
                break;
            case "apps":
                Text = "Amazing: $500,000,000,000\nPineapple: $400,000,000,000\nGoggles: $250,000,000,000\nMacrohard: $150,000,000,000\n"+
                "Databook: $75,000,000,000\nNetfilms: $30,000,000,000\nAdoben: $15,000,000,000\neBye: $7,000,000,000";
                break;
            case "phones":
                Text = "Pineapple: $350,000,000,000\nSam's Song: $240,000,000,000\nWhat: $95,000,000,000\nLegend: $60,000,000,000\n"+
                "Showme: $50,000,000,000\nOops: $40,000,000,000\nZEE: $20,000,000,000\nLive: $8,000,000,000\nLS: $5,000,000,000\n"+
                "TwoTouch: $150,000,000";
                break;
            case "yourarse":
                Text = "Indian Stuff: $1,000,000,000\nMrBest: $260,000,000\nPieDiePew: $222,000,000\n50-hour crafts: $156,000,000";
                break;
        }
        Text += "\n" + Global.CompanyName + ": $" + String.Format("{0:n0}", Global.Money);
        base._Ready();
    }
}
