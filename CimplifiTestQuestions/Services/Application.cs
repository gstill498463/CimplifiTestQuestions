namespace CimplifiTestQuestions.Services
{
    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.Log("Running Cimplifi Test Questions!");
        }
    }
}
