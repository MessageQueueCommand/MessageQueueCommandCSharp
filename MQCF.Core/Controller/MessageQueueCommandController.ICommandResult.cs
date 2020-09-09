using System;
using System.Threading.Tasks;
using MQCF.Core.Commands;
using MQCF.Core.Context;

namespace MQCF.Core.Controller
{
    /// <summary>
    /// It is the base Controller, inherit it for receive messages.
    /// </summary>
    public abstract partial class MessageQueueCommandController : IMessageQueueResults
    {
        public ICommandResult Ok<TResult>(TResult result)
        {
           return new OkCommandResult<TResult>(result);
        }
    }
}