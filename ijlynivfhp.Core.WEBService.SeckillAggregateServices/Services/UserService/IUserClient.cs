using ijlynivfhp.Core.WEBService.Cores.Proxy;
using ijlynivfhp.Core.WEBService.Cores.Proxy.Attributes;
using ijlynivfhp.Core.WEBService.UserServices.Models;

namespace ijlynivfhp.Core.WEBService.SeckillAggregateServices.Services
{
    /// <summary>
    /// 用户微服务客户端
    /// </summary>
    [MicroClient("http", "UserServices")]
    public interface IUserClient
    {
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        [PostPath("/Users")]
        public User RegistryUsers(User user);
    }
}
