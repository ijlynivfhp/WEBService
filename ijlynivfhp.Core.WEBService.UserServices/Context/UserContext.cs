using Microsoft.EntityFrameworkCore;
using ijlynivfhp.Core.WEBService.UserServices.Models;

namespace ijlynivfhp.Core.WEBService.UserServices.Context
{
    /// <summary>
    /// 用户服务上下文
    /// </summary>
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        /// <summary>
        /// 用户集合
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
