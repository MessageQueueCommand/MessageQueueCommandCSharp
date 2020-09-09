namespace MQCF.Core.Context
{
    public interface IMessageQueueContext
    {
        object Response { get; }
        object Request { get;  }
    }
}