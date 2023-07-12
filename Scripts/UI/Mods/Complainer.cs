using Godot;
using System;

public class Complainer : Label {
    private string logFilePath;
    private File logFile;
    private ulong lastModifiedTime;

    public override void _Ready() {
        logFilePath = "user://logs/godot.log";

        logFile = new File();
        if (logFile.FileExists(logFilePath)) {
            logFile.Open(logFilePath, File.ModeFlags.Read);
            lastModifiedTime = logFile.GetModifiedTime(logFilePath);
        }

        Engine.GetMainLoop().Connect("idle_frame", this, nameof(UpdateLogDisplay));
    }

    public override void _ExitTree() {
        if (logFile != null && logFile.IsOpen()) {
            logFile.Close();
            logFile = null;
        }
    }

    private void UpdateLogDisplay() {
        if (logFile != null && logFile.IsOpen()) {
            var modifiedTime = logFile.GetModifiedTime(logFilePath);

            // has the log file been modified
            if (modifiedTime > lastModifiedTime) {
                logFile.SeekEnd();
                var newContent = logFile.GetAsText();
                if (!string.IsNullOrEmpty(newContent)) {
                    Text = newContent;
                }

                lastModifiedTime = modifiedTime;
            }
        }
    }
}
