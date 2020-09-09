namespace MQCF.Core.Context
{
    public interface IMessageQueueContextAccessor
    {
        IMessageQueueContext MessageQueueContext { get; }
    }
}