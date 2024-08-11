using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace PulpoLineTest.Filte
{
    public class LoggingActionFilter(ILogger<LoggingActionFilter> logger) : IActionFilter
    {
        private readonly ILogger<LoggingActionFilter> _logger = logger;
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();

            var request = context.HttpContext.Request;
            var logMessage = $"Request: {request.Method} {request.Path}";
            _logger.LogInformation(logMessage);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            var response = context.HttpContext.Response;
            var logMessage = $"Response: {response.StatusCode} - Elapsed Time: {_stopwatch.ElapsedMilliseconds}ms";
            _logger.LogInformation(logMessage);
        }
    }
}
