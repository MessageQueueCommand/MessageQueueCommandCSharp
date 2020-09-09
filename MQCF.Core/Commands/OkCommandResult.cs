namespace MQCF.Core.Commands
{
    public class OkCommandResult<TResult> : BaseCommandResult<TResult>
    {
        private const int DefaultStatusCode = StatusCodes.Ok;

        public OkCommandResult(TResult result) 
            : base(result, DefaultStatusCode)
        {
        }
    }
}