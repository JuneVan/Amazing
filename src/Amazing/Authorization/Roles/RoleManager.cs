using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Amazing.Authorization.Roles
{
    public class RoleManager : RoleManager<Role>
    {
        public RoleManager(ISignal signal,
            IServiceProvider serviceProvider,
            IRoleStore roleStore,
            IEnumerable<IRoleValidator<Role>> roleValidators,
            ILookupNormalizer lookupNormalizer,
            IdentityErrorDescriber errors,
            ILogger<RoleManager<Role>> logger) :
            base(roleStore,
                roleValidators,
                lookupNormalizer,
                errors,
                logger
                )
        {
            Signal = signal;
            RoleStore = roleStore;
            PermissionProviders = serviceProvider.GetServices<IPermissionProvider>();
            Initialize();
        }
        protected ISignal Signal { get; }
        protected override CancellationToken CancellationToken => Signal.Token;
        protected IRoleStore RoleStore { get; }
 
        protected IEnumerable<IPermissionProvider> PermissionProviders { get; }

        public List<PermissionDefinition> Permissions { get; } = new List<PermissionDefinition>();

        private void Initialize()
        {
            if (PermissionProviders != null)
            {
                foreach (var provider in PermissionProviders)
                {
                    Permissions.AddRange(provider.Definitions());
                }
            }
        } 

        public async Task<List<PermissionDefinition>> GetPermissionsAsync(Role role)
        {
            if (PermissionProviders == null)
                return null;
            var permissions= await RoleStore.GetPermissionClaimsAsync(role, CancellationToken);

            if (permissions != null)
                RecursivelyPermission(Permissions, permissions);
            return Permissions;
        } 

        private void RecursivelyPermission(List<PermissionDefinition> permissionDefinitions, IList<string> rolePermissions)
        {
            foreach (var permissionDefinition in permissionDefinitions)
            {
                var rolePermission = rolePermissions.FirstOrDefault(f => f == permissionDefinition.Name);
                if (rolePermission != null)
                    permissionDefinition.IsGrant = true;
                if (permissionDefinition.Children.Count > 0)
                {
                    RecursivelyPermission(permissionDefinition.Children.ToList(), rolePermissions);
                }
            }
        }
    }
}
