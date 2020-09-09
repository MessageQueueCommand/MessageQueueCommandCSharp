using System;
using System.ComponentModel;
using System.Xml;

namespace MQCF.Core.Commands
{
    public interface ICommandResult
    {
        public int Status { get; }
    }
    
    public interface ICommandResult<out TResult> : ICommandResult
    {
        TResult Result { get;}
    }
}