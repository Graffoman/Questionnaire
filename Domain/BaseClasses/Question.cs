using Domain.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities.BaseClasses
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(QuestionCheckbox), typeof(QuestionIntRange), typeof(QuestionMultipleSelect), typeof(QuestionSelect), typeof(QuestionText))]
    public class Question
    {
        [BsonId]
        public string Id { get; set; }
        public QuestionType Type { get; set; }
        public string QuestionText { get; set; }
        public bool IsOptional { get; set; }
    }
}
