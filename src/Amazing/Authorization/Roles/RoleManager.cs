using System.Collections.Generic;

namespace Amazing.Authorization.Roles
{
    public class RoleManager
    {
        public RoleManager(ISignal signal,
            IRoleStore roleStore,
            IEnumerable<IRoleValidator> roleValidators,
             IStringNormalizer stringNormalizer)
        {
            Signal = signal;
            RoleStore = roleStore;
            RoleValidators = roleValidators;
            StringNormalizer = stringNormalizer;
        }
        protected ISignal Signal { get; }
        protected IRoleStore RoleStore { get; }
        protected IEnumerable<IRoleValidator> RoleValidators { get; }
        protected IStringNormalizer StringNormalizer { get; }


    }
}
