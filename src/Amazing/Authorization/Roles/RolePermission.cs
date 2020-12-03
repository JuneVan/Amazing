using System;

namespace Amazing.Authorization.Roles
{
    public class RolePermission
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsGrant { get; set; }
        public virtual Guid RoleId { get; set; }
    }
}
