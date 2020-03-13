using Base.Domain.Common;

namespace IDS.Domain.AggregateModels.UserAggregate
{
    public class Identity : Entity
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
        public Identity()
        {

        }
    }
}
