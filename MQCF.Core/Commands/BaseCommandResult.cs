namespace MQCF.Core.Commands
{
    public abstract class BaseCommandResult<TResult> : ICommandResult<TResult>
    {
        protected BaseCommandResult(TResult result, int status )
        {
            Status = status;
        }
        
        public TResult Result { get; }
        public int Status { get; }
    }
}