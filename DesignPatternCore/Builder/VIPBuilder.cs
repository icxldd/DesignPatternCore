using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Builder
{
    /// <summary>
    /// vip打8折
    /// </summary>
    public class VIPBuilder : BuyBuilder
    {
        protected override BuyList buy_List { get; set; } = new BuyList(eBuyRole.vip);

        public override void buyDress()
        {
            Product product = new Product();
            product.productName = "衣服零件";
            PartPrice part = new PartPrice("布料", moneyDiscounts(300));
            PartPrice part2 = new PartPrice("扣子", moneyDiscounts(50));
            product.parts.Add(part);
            product.parts.Add(part2);
            buy_List.add(product);
        }

        public override void buySupplies()
        {
            Product product = new Product();
            product.productName = "生活用品";
            PartPrice part = new PartPrice("牙刷", moneyDiscounts(30));
            PartPrice part2 = new PartPrice("被子", moneyDiscounts(100));
            product.parts.Add(part);
            product.parts.Add(part2);
            buy_List.add(product);
        }

        public override double moneyDiscounts(double money)
        {
            return money * 0.8;
        }
    }
}
