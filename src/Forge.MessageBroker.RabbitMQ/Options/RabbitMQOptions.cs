﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge.MessageBroker.RabbitMQ.Options
{
    public class RabbitMQOptions : IRabbitMQOptions
    {
        public const string DefaultSectionName = "rabbit";

        public string HostName { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string VirtualHost { get; set; }
    }
}
