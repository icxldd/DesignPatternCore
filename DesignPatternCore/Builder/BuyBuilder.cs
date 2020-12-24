using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Builder
{
    public abstract class BuyBuilder
    {
        /// <summary>
        /// 本次购买清单
        /// </summary>
        protected abstract BuyList buy_List { get; set; }
        /// <summary>
        /// 买衣服
        /// </summary>
        public abstract void buyDress();

        /// <summary>
        /// 买生活用品
        /// </summary>
        public abstract void buySupplies();

        /// <summary>
        /// 这个角色购买金钱折扣
        /// </summary>
        /// <returns></returns>
        public abstract double moneyDiscounts(double money);


        /// <summary>
        /// 获取本次购买清单列表
        /// </summary>
        /// <returns></returns>
        public BuyList GetBuyList() { return buy_List; }


    }
}
