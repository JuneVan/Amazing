using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazing.Authorization.Roles
{
    public interface IRoleStore
    {
        Task<AmazingResult> CreateAsync(Role role, CancellationToken cancellaction);
        Task<AmazingResult> UpdateAsync(Role role, CancellationToken cancellaction);
        Task<AmazingResult> DeleteAsync(Role role, CancellationToken cancellaction);
        Task<Role> FindByIdAsync(Guid roleId, CancellationToken cancellaction);
        Task<Role> FindByNameAsync(string normalizedName, CancellationToken cancellaction);
    }
}
