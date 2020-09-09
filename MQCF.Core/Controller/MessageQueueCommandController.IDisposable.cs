using System;
using MQCF.Core.Context;

namespace MQCF.Core.Controller
{
    /// <summary>
    /// It is the base Controller, inherit it for receive messages.
    /// </summary>
    public abstract partial class MessageQueueCommandController : IDisposable
    {
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}