using System;

namespace MQCF.Core
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class MessageQueueRoutingAttribute : Attribute
    {
        /// <summary>
        /// The MessageQueue Name - It can be empty, then it would be ignored and only the command decides the action.
        /// </summary>
        public string MessageQueueName { get; }

        public MessageQueueRoutingAttribute(string messageQueueName)
        {
            MessageQueueName = messageQueueName;
        }
    }
}