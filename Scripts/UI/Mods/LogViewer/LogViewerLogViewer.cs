using Godot;
using System;

public class LogViewerLogViewer : Label {
    public override void _Ready() {
        base._Ready();
        if (Global.CurrentLogFile != "nuh uh") {
            File hjkd = new File();
            if (hjkd.Open($"user://logs/{Global.CurrentLogFile}", File.ModeFlags.Read) == Error.Ok) {
                Text = hjkd.GetAsText();
                hjkd.Close();
            } else {
                Text = $"Failed to open {Global.CurrentLogFile}";
            }
        }
    }
}
