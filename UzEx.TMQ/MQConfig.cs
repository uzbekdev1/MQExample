using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzEx.TMQ
{
    public struct MQConfig
    {

        public const string QueueManagerName = "SE.EXT";
         
        public const string ChannelInfo = "SVRCONN/TCP/172.16.14.114(1415)";

        public const string ReceiverQueueName = "CC.FROM";

        public const string SenderQueueName = "CC.TO";

    }
}
