using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class User : IIdentifieble
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
}
