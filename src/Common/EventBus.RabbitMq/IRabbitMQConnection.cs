using RabbitMQ.Client;
using System;
namespace EventBus.RabbitMq
{
    public interface IRabbitMQConnection : IDisposable
    {
        bool IsConnected { get; }
        bool TryConnect();
        IModel CreateModel();
    }
}