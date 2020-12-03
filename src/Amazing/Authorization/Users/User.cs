using Microsoft.AspNetCore.Identity;
using System;

namespace Amazing.Authorization.Users
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        public User() { }
        public User(string userName) : base(userName)
        {
        }

        /// <summary>
        /// 名
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 姓
        /// </summary>
        public virtual string Surname { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string FullName => Surname + Name;
        /// <summary>
        /// 个人头像
        /// </summary>
        public virtual string Photo { get; set; }
        /// <summary>
        /// 受保护状态（不可删除）
        /// </summary>
        public virtual bool Protected { get; set; }
        /// <summary>
        /// 确认状态
        /// </summary>
        public virtual bool Confirmed { get; set; }

        public class Constants
        {
            public const int MaxUserNameLength = 32;
            public const int MaxNormalizedUserNameLength = 32;
            public const int MaxEmailLength = 256;
            public const int MaxNormalizedEmailLength = 256;
            public const int MaxPasswordHashLength = 128;
            public const int MaxPhoneNumberLength = 16;
            public const int MaxNameLength = 16;
            public const int MaxSurnameLength = 16;
            public const int MaxPhotoLength = 1024;
        }
    }
}
