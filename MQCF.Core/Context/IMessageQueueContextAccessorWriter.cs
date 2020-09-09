namespace MQCF.Core.Context
{
    internal interface IMessageQueueContextAccessorWriter
    {
        IMessageQueueContextWriter MessageQueueContextWriter { get; set; }
    }
}