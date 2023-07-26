using Godot;
using System;
using System.Collections.Generic;

public class LogViewerList : VBoxContainer {
    public override void _Ready() {
        base._Ready();
        // the J
        Directory pain = new Directory();
        List<string> logFiles = new List<string>();
        pain.Open("user://logs/");
        pain.ListDirBegin(true);
        string filename = pain.GetNext();
        while (filename != "") {
            if (filename != "godot.log") {
                logFiles.Add(filename);
            }
            filename = pain.GetNext();
        }
        pain.ListDirEnd();

        // make a list of more readable things
        List<string> logs = new List<string>();
        foreach (var whytho in logFiles) {
            // ignore the godot prefix and .log suffix
            string timestamp = whytho.Substring(5, 19);
            DateTime bruh = DateTime.ParseExact(timestamp, "yyyy-MM-ddTHH.mm.ss", null);
            // too lazy to make this less shit
            logs.Add($"{bruh.Year}/{bruh.Month.ToString("D2")}/{bruh.Day.ToString("D2")} {bruh.Hour.ToString("D2")}:{bruh.Minute.ToString("D2")}:{bruh.Second.ToString("D2")}");
        }

        // add the buttons
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/LogViewerButton.tscn");
        for (int i = 0; i < logs.Count; i++) {
            LogViewerButton OK = (LogViewerButton)yes.Instance();
            OK.Init(logFiles[i], logs[i]);
            AddChild(OK);
        }
    }
}
