using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Builder
{


    public enum eBuyRole
    {
        vip,
        common
    }

    public class Product
    {
        public string productName { get; set; }

        public List<PartPrice> parts { get; set; } = new List<PartPrice>();

    }


    public class PartPrice
    {
        public string partName { get; set; }
        public double price { get; set; }
        public PartPrice(string partName, double price)
        {
            this.partName = partName;
            this.price = price;
        }
    }


    public class BuyList
    {

        public BuyList(eBuyRole role)
        {
            this._buyRole = role;
        }

        private eBuyRole _buyRole;

        private List<Product> prductList = new List<Product>();

        public void add(Product product)
        {
            prductList.Add(product);
        }

        public List<Product> getPrductList()
        {
            return this.prductList;
        }


        public void show()
        {
            Console.WriteLine("当前角色是" + _buyRole);

            foreach (var prduct in prductList)
            {
                Console.WriteLine("当前购买的商品是：" + prduct.productName);
                Console.WriteLine("开始打印商品详细单");
                foreach (var part in prduct.parts)
                {
                    Console.WriteLine($"零件{part.partName}->{part.price}RMB");
                }

            }
        }
    }



}
