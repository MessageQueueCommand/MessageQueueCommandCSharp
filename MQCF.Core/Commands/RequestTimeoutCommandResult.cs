namespace MQCF.Core.Commands
{
    public class RequestTimeoutCommandResult<TResult> : BaseCommandResult<TResult>
    {
        private const int DefaultStatusCode = StatusCodes.RequestTimeout;

        public RequestTimeoutCommandResult(TResult result, int status) : base(result, status)
        {
        }
    }
}