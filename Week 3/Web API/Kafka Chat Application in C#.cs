using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer =
    new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Kafka Producer Started");

while (true)
{
    Console.Write("Enter Message : ");

    var message = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(message))
        break;

    var result = await producer.ProduceAsync(
        "ChatTopic",
        new Message<Null, string>
        {
            Value = message
        });

    Console.WriteLine($"Delivered : {result.Value}");
}

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "chat-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer =
    new ConsumerBuilder<Ignore, string>(config).Build();

consumer.Subscribe("ChatTopic");

Console.WriteLine("Kafka Consumer Started...");
Console.WriteLine("Waiting for messages...\n");

try
{
    while (true)
    {
        var consumeResult = consumer.Consume();

        Console.WriteLine($"Received: {consumeResult.Message.Value}");
    }
}
catch (OperationCanceledException)
{
    consumer.Close();
}


namespace KafkaChatApp
{
    public partial class Form1 : Form
    {
        ProducerConfig producerConfig;
        ConsumerConfig consumerConfig;

        public Form1()
        {
            InitializeComponent();

            producerConfig = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            consumerConfig = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = Guid.NewGuid().ToString(),
                AutoOffsetReset = AutoOffsetReset.Latest
            };

            Task.Run(StartConsumer);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            using var producer =
                new ProducerBuilder<Null, string>(producerConfig).Build();

            await producer.ProduceAsync(
                "ChatTopic",
                new Message<Null, string>
                {
                    Value = txtMessage.Text
                });

            txtMessage.Clear();
        }

        private void StartConsumer()
        {
            using var consumer =
                new ConsumerBuilder<Ignore, string>(consumerConfig).Build();

            consumer.Subscribe("ChatTopic");

            while (true)
            {
                var result = consumer.Consume();

                Invoke(new Action(() =>
                {
                    lstChat.Items.Add(result.Message.Value);
                }));
            }
        }
    }
}
namespace KafkaChatApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}