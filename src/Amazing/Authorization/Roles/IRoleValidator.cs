using System.Threading.Tasks;

namespace Amazing.Authorization.Roles
{
    public interface IRoleValidator
    {
        Task<AmazingResult> ValidateAsync(RoleManager manager, Role role);
    }
}
