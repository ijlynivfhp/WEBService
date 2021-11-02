﻿namespace ijlynivfhp.Projects.ProductServices.Vos
{
    /// <summary>
    /// 商品值对象，主要接受客户端传过来的参数
    /// </summary>
    public class ProductPo
    {
        // 商品编号
        public int ProductId { set; get; }
        // 商品数量
        public int ProductCount { set; get; }
    }
}
