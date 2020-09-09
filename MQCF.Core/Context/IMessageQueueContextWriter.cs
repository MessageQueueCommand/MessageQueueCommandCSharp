namespace MQCF.Core.Context
{
    internal interface IMessageQueueContextWriter: IMessageQueueContext    
    {
        new object Response { get; set; }
        new object Request { get; set; }
    }
}