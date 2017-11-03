using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace AmqpComponent
{
    /// <summary>
    /// 消息上下文
    /// </summary>
    public class MessageContext
    {
        public IConnection ListenConnection { get; set; }

        public IModel ListenCannel { get; set; }
    }
}
