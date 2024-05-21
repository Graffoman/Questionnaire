using Domain.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Domain.Entities.BaseClasses
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(QuestionCheckbox), typeof(QuestionIntRange), typeof(QuestionMultipleSelect), typeof(QuestionSelect), typeof(QuestionText))]
    public class Question
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string Id { get; set; }
        public QuestionType Type { get; set; }
        public string QuestionText { get; set; }
        public bool IsOptional { get; set; }
    }
}
