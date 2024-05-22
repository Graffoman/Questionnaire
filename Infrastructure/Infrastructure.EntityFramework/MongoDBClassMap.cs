using Domain.Entities;
using Domain.Entities.BaseClasses;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace Infrastructure.DataAcces
{
    public class MongoDBClassMap
    {
        public static void RegisterClassMaps()
        {
            BsonClassMap.RegisterClassMap<User>(cm =>
            {
                cm.AutoMap();
                cm.MapIdMember(x => x.Id)
                    .SetIdGenerator(new StringObjectIdGenerator())
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });

            BsonClassMap.RegisterClassMap<Question>(cm =>
            {
                cm.AutoMap();
                //cm.MapIdMember(x => x.Id)
                //    .SetIdGenerator(new StringObjectIdGenerator())
                //    .SetSerializer(new StringSerializer(BsonType.ObjectId));
                cm.SetIsRootClass(true);
                cm.AddKnownType(typeof(QuestionCheckbox));
                cm.AddKnownType(typeof(QuestionIntRange));
                cm.AddKnownType(typeof(QuestionMultipleSelect));
                cm.AddKnownType(typeof(QuestionSelect));
                cm.AddKnownType(typeof(QuestionText));
            });

            BsonClassMap.RegisterClassMap<QuestionCheckbox>();
            BsonClassMap.RegisterClassMap<QuestionIntRange>();
            BsonClassMap.RegisterClassMap<QuestionMultipleSelect>();
            BsonClassMap.RegisterClassMap<QuestionSelect>();
            BsonClassMap.RegisterClassMap<QuestionText>();

            BsonClassMap.RegisterClassMap<IntRange>(cm =>
            {
                cm.MapCreator(r => new IntRange(r.From, r.To));
            });

            BsonClassMap.RegisterClassMap<Questionnaire>(cm =>
            {
                cm.AutoMap();
                cm.MapIdMember(x => x.Id)
                    .SetIdGenerator(new StringObjectIdGenerator())
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }
    }
}
