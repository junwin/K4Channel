using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using log4net;

using System.Collections.Generic;

namespace K4Channel
{
    [TestClass]
    public class MSBChannelTest
    {
        int msgCount = 0;
         private ILog log;
        private List<IChannelDefinition> cdSettings;

        public MSBChannelTest()
        {
            log = Mock.Of<ILog>();
            cdSettings = new List<IChannelDefinition>();
            
            TestScafold.SetChannelDefinitionDefaults(cdSettings);
        }


        private void OnMessageEvent(object sender, IMessage myMessage)
        {
            msgCount++;
        }

        [TestMethod]
        public void MSBBasicChannelTests()
        {
            var log =  Mock.Of<ILog>();
            ChannelFactory cf = new ChannelFactory(cdSettings, log);


            IChannel ch = cf.Create("MSB");
            ch.OnMessage += new OnMessageEvent(OnMessageEvent);
            ch.Open();

            IMessage msg = new Message();

            msg.Label = "bloop";
            msg.Data = "bloopper";
            msg.TargetSubID = MQRoutingKeyPrefix.INFO;

            ch.Send(msg);

            ch.Begin();

            ch.Send(msg);
            System.Threading.Thread.Sleep(5000);

        }
    }
}
