namespace RabbitMQ.Abstractions
{
    public class Notification
    {
        public string UserId { get; set; }
        public string OpenQuestionnaireUrl { get; set; }
        public string MessageText { get; set; }
    }
}