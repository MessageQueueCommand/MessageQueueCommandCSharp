using System;

namespace MQCF.Core
{
    /// <summary>
    /// This attribute describes for an action the conditions to match 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class MessageQueueCommandAttribute : Attribute
    {
        /// <summary>
        /// The MessageQueue Name - It can be empty, then it would be ignored and only the command decides the action.
        /// </summary>
        public string MessageQueueName { get; }
        
        /// <summary>
        /// With the CommandName we route the message to the controller function. 
        /// </summary>
        public string CommandName { get; }
        
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="commandName">With the CommandName we route the message to the controller function.</param>
        public MessageQueueCommandAttribute(string commandName) : this(string.Empty,commandName) {}

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="messageQueueName">The MessageQueue Name - It can be empty, then it would be ignored and only the command decides the action.</param>
        /// <param name="commandName"></param>
        public MessageQueueCommandAttribute(string messageQueueName, string commandName)
        {
            MessageQueueName = messageQueueName;
            CommandName = commandName;
        }
        
    }
}