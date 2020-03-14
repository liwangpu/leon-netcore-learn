using Base.Domain.Common;
using System.Collections.Generic;

namespace Base.API
{
    internal class ProfileContext : IProfileContext
    {
        public long? IdentityId { get; }
        public string ClientId { get; }

        public long? TenantId { get; }

        public long? UserId { get; }

        public string UserName { get; }

        public IDictionary<string, object> Properties { get; }

        public ProfileContext(long? identityId, long? userId, string userName, long? tenantId, string clientId)
        {
            IdentityId = identityId;
            UserId = userId;
            UserName = userName;
            TenantId = tenantId;
            ClientId = clientId;
            Properties = new Dictionary<string, object>();
        }

    }
}
