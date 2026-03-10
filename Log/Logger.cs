using System;
using System.IO;

public static class Logger
{
    private static string logFilePath = "app.log";

    static Logger()
    {
        string debugPath = Application.StartupPath;

        string relativePath = @"..\..\..\Log\" + $"{logFilePath}";
        logFilePath = Path.GetFullPath(relativePath);

        // Lấy thư mục chứa file
        string? logFileDirect = Path.GetDirectoryName(logFilePath);

        // Nếu chưa có thư mục thì tạo mới
        if (!string.IsNullOrEmpty(logFileDirect))
        {
            if (!Directory.Exists(logFileDirect))
            {
                Directory.CreateDirectory(logFileDirect);
            }
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Close();
            }
        }
    }

    public static string getRelativePath(string filename)
    {
        ConfigFile(filename);
        string relativePath = @"..\..\..\Log\" + $"{logFilePath}";
        string? logFileDict = Path.GetDirectoryName(relativePath);
        string logFilePathFull = Path.GetFullPath(relativePath);

        
        // Nếu chưa có thư mục thì tạo mới
        if (!string.IsNullOrEmpty(logFileDict))
        {
            if (!Directory.Exists(logFileDict))
            {
                Directory.CreateDirectory(logFileDict);
            }
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Close();
            }
        }

        return @"..\..\..\Log\" + $"{logFilePath}";
    }
    public static void ConfigFile(string filename)
    {
        if (filename != null)
        {
            logFilePath = filename;
        }

    }
    public static void LogError(Exception ex)
    {
        string message = $"[{DateTime.Now}] ERROR: {ex.Message}\n{ex.StackTrace}\n";
        File.AppendAllText(logFilePath, message);
    }

    // Ghi thông tin
    public static void LogInfo(string info)
    {
        if (!File.Exists(logFilePath))
        {
            File.Create(logFilePath).Close();
        }
        string message = $"[{DateTime.Now}] INFO: {info}\n";
        File.AppendAllText(logFilePath, message);
    }

    // Ghi cảnh báo
    public static void LogWarning(string warning)
    {
        string message = $"[{DateTime.Now}] WARNING: {warning}\n";
        File.AppendAllText(logFilePath, message);
    }
}