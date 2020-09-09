using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.AspNetCore.Mvc;
using MQCF.Core;
using MQCF.Core.Commands;
using MQCF.Core.Controller;

namespace MQCF.Example.MqControllers
{
    public class HomeController : MessageQueueCommandController
    {
        [MessageQueueCommand("Home")]
        public ICommandResult Home()
        {
            return Ok("Hello Welt!");        
        }
    }
}