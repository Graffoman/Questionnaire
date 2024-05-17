using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities.BaseClasses
{
    public class IntRange
    {
        public int From { get; set; }
        public int To { get; set; }

        [BsonConstructor]
        public IntRange(int from, int to)
        {
            From = from;
            To = to;
        }
    }
}
