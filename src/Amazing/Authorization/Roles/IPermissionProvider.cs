using System.Collections.Generic;

namespace Amazing.Authorization.Roles
{
    public interface IPermissionProvider
    {
        IEnumerable<PermissionDefinition> Definitions();
    }
}
