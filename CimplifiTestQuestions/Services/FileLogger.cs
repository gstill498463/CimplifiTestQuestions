namespace CimplifiTestQuestions.Services
{
    using System.IO;
    public class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string path)
        {
            filePath = path;
        }

        public void Log(string message)
        {
            File.AppendAllText(filePath, $"File Logger: {message}{Environment.NewLine}");
        }
    }
}
