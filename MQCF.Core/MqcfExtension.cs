using Microsoft.Extensions.DependencyInjection;
using MQCF.Core.Context;

namespace MQCF
{
    public static class MqcfExtension
    {
        /// <summary>
        /// Register thw MQCF Framework
        /// </summary>
        /// <param name="serviceCollection">The <see cref="IServiceCollection"/> to register with.</param>
        /// <returns>The original <see cref="IServiceCollection"/>.</returns>
        // ReSharper disable once InconsistentNaming
        public static IServiceCollection AddMessageQueueCommandFramework(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IMessageQueueContextAccessor, MessageQueueContextAccessor>();
            
            return serviceCollection;
        }
    }
}