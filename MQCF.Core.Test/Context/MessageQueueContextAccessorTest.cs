using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MQCF.Core.Context;

namespace MQCF.Core.Test.Context
{
    [TestClass]
    public class MessageQueueContextAccessorTest    
    {
        [TestMethod]
        public void IsContextSetToTheAccessor()
        {
            // Arrange  
            var obj = new object();
            var context = new MessageQueueContext
            {
                Request = obj
            };

            // Act
            var accessor = new MessageQueueContextAccessor()
            {
                MessageQueueContextWriter = context
            };

            // Assert
            Assert.IsNotNull(accessor.MessageQueueContext);
            Assert.AreSame(obj , accessor.MessageQueueContext.Request);
        }
        
        [TestMethod]
        public void IsContextSetToTheAccessorAndDelete()
        {
            // Arrange  
            var obj = new object();
            var context = new MessageQueueContext
            {
                Request = obj
            };

            // Act
            var accessor = new MessageQueueContextAccessor()
            {
                MessageQueueContextWriter = context
            };
            accessor.MessageQueueContextWriter = null;
                
            // Assert
            Assert.IsNull(accessor.MessageQueueContext);
        }
    }
}