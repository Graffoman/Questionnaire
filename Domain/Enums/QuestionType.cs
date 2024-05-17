using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Domain.Entities.Enums
{
    public enum QuestionType
    {
        [BsonRepresentation(BsonType.String)]
        IntRange,
        [BsonRepresentation(BsonType.String)]
        Checkbox,
        [BsonRepresentation(BsonType.String)]
        Text,
        [BsonRepresentation(BsonType.String)]
        Select,
        [BsonRepresentation(BsonType.String)]
        MultipleSelect
    }
}
