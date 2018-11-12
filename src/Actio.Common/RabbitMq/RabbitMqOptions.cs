using RawRabbit.Configuration;

namespace Actio.Common.RabbitMq
{
    public class RabbitMqOptions : RawRabbitConfiguration
    {
        public RabbitMqOptions ClientConfiguration { get; set; }
    }
}