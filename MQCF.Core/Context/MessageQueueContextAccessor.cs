using System.Threading;

namespace MQCF.Core.Context
{
    internal sealed class MessageQueueContextAccessor : IMessageQueueContextAccessor, IMessageQueueContextAccessorWriter
    {
        private static readonly AsyncLocal<MessageQueueContextWriterHolder> MessageQueueContextWriterCurrent = new AsyncLocal<MessageQueueContextWriterHolder>();

        public IMessageQueueContext MessageQueueContext => MessageQueueContextWriter;

        public IMessageQueueContextWriter MessageQueueContextWriter
        {
            get
            {
                return MessageQueueContextWriterCurrent.Value?.Context;
            }
            set
            {
                var holder = MessageQueueContextWriterCurrent.Value;
                if (holder != null)
                {
                    // Clear current MessageContext trapped in the AsyncLocals, as its done.
                    holder.Context = null;
                }

                if (value != null)
                {
                    // Use an object indirection to hold the MessageContext in the AsyncLocal,
                    // so it can be cleared in all ExecutionContexts when its cleared.
                    MessageQueueContextWriterCurrent.Value = new MessageQueueContextWriterHolder() { Context = value };
                }
            }
        }

        private class MessageQueueContextWriterHolder
        {
            public IMessageQueueContextWriter Context;
        }
    }
}