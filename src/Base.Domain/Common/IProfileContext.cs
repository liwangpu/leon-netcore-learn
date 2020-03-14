using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Domain.Common
{
    public interface IProfileContext
    {
        string ClientId { get; }

        long? TenantId { get; }

        long? UserId { get; }
        long? IdentityId { get; }

        string UserName { get; }

        IDictionary<string, object> Properties { get; }
    }
}
