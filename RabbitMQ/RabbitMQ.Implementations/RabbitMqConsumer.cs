using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Abstractions;
using Services.Abstractions;
using System.Text.Json;
using Services.Contracts.UserDto;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace RabbitMQ.Implementations
{
    public class RabbitMqConsumer : BackgroundService
    {
        private IConnection _connection;
        private IModel _channel;
        private RabbitSettings _settings;
        private IUserService _userService;
        private ILogger _logger;

        public RabbitMqConsumer(RabbitSettings settings, IUserService userService, ILogger<RabbitMqConsumer> logger)
        {
            _settings = settings;
            _userService = userService;
            _logger = logger;

            var factory = new ConnectionFactory
            {
                HostName = _settings.HostName,
                UserName = _settings.UserName,
                Password = _settings.Password
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(
                queue: settings.UsersQueueName,
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null
                );
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += async (ch, ea) =>
            {
                var content = Encoding.UTF8.GetString(ea.Body.ToArray());
                _logger.LogInformation($"Получено сообщение из очереди: {_settings.UsersQueueName}");

                try
                {
                    var createUserDto = JsonConvert.DeserializeObject<CreateUserDto>(content);
                    var id = await _userService.CreateAsync(createUserDto);
                    _logger.LogInformation("Добавлен новый пользователь: {id}", id);
                }
                catch (Exception e)
                {
                    _logger.LogWarning("Не удалось добавить нового пользователя из сообщения: {content}", content, e);
                }

                _channel.BasicAck(ea.DeliveryTag, false);
            };

            _channel.BasicConsume(_settings.UsersQueueName, false, consumer);

            return Task.CompletedTask;
        }

        public override void Dispose()
        {
            _channel.Close();
            _connection.Close();
            base.Dispose();
        }
    }
}
