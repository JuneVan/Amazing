using System;

namespace Amazing.Authorization.Users
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        public User() { }
        public User(string userName) : this()
        {
            UserName = userName;
        }
        public virtual Guid Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string UserName { get; set; }
        /// <summary>
        /// 标准化的用户名
        /// </summary>
        public virtual string NormalizedUserName { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public virtual string Email { get; set; }
        /// <summary>
        /// 标准化的邮箱
        /// </summary>
        public virtual string NormalizedEmail { get; set; }
        /// <summary>
        /// 邮箱确认状态
        /// </summary>
        public virtual bool EmailConfirmed { get; set; }
        /// <summary>
        /// 密码加密值
        /// </summary>
        public virtual string PasswordHash { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public virtual string PhoneNumber { get; set; }
        /// <summary>
        /// 手机确认状态
        /// </summary>
        public virtual bool PhoneNumberConfirmed { get; set; }
        /// <summary>
        /// 锁定时间
        /// </summary>
        public virtual DateTimeOffset? LockoutEnd { get; set; }
        /// <summary>
        /// 锁定状态
        /// </summary>
        public virtual bool LockoutEnabled { get; set; }
        /// <summary>
        /// 访问失败次数
        /// </summary>
        public virtual int AccessFailedCount { get; set; }
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
        public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
        public override string ToString() => UserName;

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
