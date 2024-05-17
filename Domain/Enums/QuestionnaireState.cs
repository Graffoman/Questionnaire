using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Domain.Entities.Enums
{
    public enum QuestionnaireState
    {
        [BsonRepresentation(BsonType.String)]
        ReadyToUse,
        [BsonRepresentation(BsonType.String)]
        Modifying,
        [BsonRepresentation(BsonType.String)]
        Deprecated
    }
}
