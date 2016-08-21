using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.ServiceModel;

namespace NsoupDemo.BLL
{
    /// <summary>
    /// 生产   发送消息
    /// </summary>
    public class ProducerMQ
    {
        /// <summary>
        /// 生产
        /// </summary>
        public void Emit()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "test";
            factory.Password = "test";
            while (true)
            {
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.QueueDeclare("hello", false, false, false, null);
                        string message = "Hello World";
                        var body = Encoding.UTF8.GetBytes(message);
                        channel.BasicPublish("", "hello", null, body);
                        Console.WriteLine(" set {0}", message);
                        Console.ReadLine();
                    }
                }
            }
        }

        /// <summary>
        /// 消费
        /// </summary>
        public void Receive()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            factory.UserName = "test";
            factory.Password = "test";
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("hello", false, false, false, null);

                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume("hello", true, consumer);

                    Console.WriteLine(" [*] Waiting for messages." +
                                             "To exit press CTRL+C");
                    while (true)
                    {
                        var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] Received {0}", message);
                    }
                }
            }
        }
    }
}
