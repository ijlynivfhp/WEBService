﻿using ijlynivfhp.Projects.SeckillServices.Models;
using System.Collections.Generic;

namespace ijlynivfhp.Projects.SeckillServices.Repositories
{
    /// <summary>
    /// 秒杀仓储接口
    /// </summary>
    public interface ISeckillRepository
    {
        IEnumerable<Seckill> GetSeckills();
        IEnumerable<Seckill> GetSeckills(Seckill seckill);
        Seckill GetSeckillById(int id);
        Seckill GetSeckillByProductId(int ProductId);
        void Create(Seckill Seckill);
        void Update(Seckill Seckill);
        void Delete(Seckill Seckill);
        bool SeckillExists(int id);
    }
}
