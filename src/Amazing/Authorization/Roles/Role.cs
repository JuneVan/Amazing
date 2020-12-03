using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Amazing.Authorization.Roles
{
    public class Role : IdentityRole<Guid>
    {
        public Role() { }
        public Role(string roleName) : base(roleName)
        {
        } 
        /// <summary>
        /// 显示名称
        /// </summary>
        public virtual string DisplayName { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// 激活状态
        /// </summary>
        public virtual bool Active { get; set; }
        /// <summary>
        /// 受保护状态（不可删除）
        /// </summary>
        public virtual bool Protected { get; set; }

        public class Constants
        {
            public const int MaxNameLength = 8;
            public const int MaxNormalizedNameLength = 8;
            public const int MaxDisplayNameLength = 16;
            public const int MaxDescriptionLength = 128;
        }
    }
}
