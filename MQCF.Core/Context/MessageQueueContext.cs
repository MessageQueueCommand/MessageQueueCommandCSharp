namespace MQCF.Core.Context
{
    internal sealed class MessageQueueContext : IMessageQueueContext, IMessageQueueContextWriter
    {
        public object Response { get; set; }
        public object Request { get; set; }
    }
}