namespace OpenClosed.Good
{
    public class Logger
    {
        readonly ILogger _logger;

        public Logger(ILogger logger)
        {
            this._logger = logger;
        }

        public void WriteLog(string message)
        {
            _logger.WriteLog(message);
        }
    }
}