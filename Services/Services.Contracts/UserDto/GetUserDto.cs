using MongoDB.Bson;

namespace Services.Contracts.UserDto
{
    public class GetUserDto
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
}
