using System.Threading.Tasks;
using System.Windows.Input;
using MQCF.Core.Commands;

namespace MQCF.Core.Controller
{
    public interface IMessageQueueResults
    {
        ICommandResult Ok<TResult>(TResult result);
        
    }
}