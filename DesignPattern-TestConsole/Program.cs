using DesignPatternCore.Adapter;
using DesignPatternCore.Bridge;
using DesignPatternCore.Builder;
using DesignPatternCore.Composite;
using DesignPatternCore.Decorator;
using DesignPatternCore.Facade;
using DesignPatternCore.Factory;
using DesignPatternCore.Factory.abstractFactory;
using DesignPatternCore.Factory.factoryMethod;
using DesignPatternCore.Proxy;
using DesignPatternCore.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var obj_1 = MultiThreedSingleton.GetInstance();
            //var obj_2 = MultiThreedSingleton.GetInstance();
            //if (Object.ReferenceEquals(obj_1, obj_2))
            //{
            //    Console.WriteLine("是相同的");
            //}

            //var orm = ORMProviderSimpleFactory.CreateORMProvider(eORMProvider.sqlServer);
            //orm.add();


            //var factory = new mysqlFactory();
            //factory.CreateORMFactory().add();


            //var factory = new mySqlFactory();
            //factory.CreateORM().add();

            {
                //BuyDirector buy = new BuyDirector();
                //BuyBuilder vip = new VIPBuilder();
                //BuyBuilder common = new CommonBuilder();

                //buy.Buy(vip);
                //vip.GetBuyList().show();

                //buy.Buy(common);
                //common.GetBuyList().show();


            }

            {
                //PowerAdapter adapter = new PowerAdapter();
                //adapter.request();
            }
            {
                //var control = new ORMControl(new MySqlProvider());
                //control.add();

            }

            {
                //Serve woman = new woManServe();
                //Serve man = new manServe();

                //ServeDecorator nice = new niceServeDecorator(woman);
                //nice.Print();

                //ServeDecorator invincible = new invincibleServeDecorator(nice);
                //invincible.Print();

                //ServeDecorator choulow = new uglyServeDecorator(man);
                //choulow.Print();
            }

            {
                //ComplexGraphics complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
                //complexGraphics.Add(new Line("线段A",12,32));
                //ComplexGraphics CompositeCG = new ComplexGraphics("一个圆和一条线组成的复杂图形");
                //CompositeCG.Add(new Circle("圆",55,11));
                //CompositeCG.Add(new Circle("圆B", 123,131));
                //complexGraphics.Add(CompositeCG);
                //Line l = new Line("线段C",1231,1323);
                //complexGraphics.Add(l);

                //// 显示复杂图形的画法
                //Console.WriteLine("复杂图形的绘制如下：");
                //Console.WriteLine("---------------------");
                //complexGraphics.Draw();
                //Console.WriteLine("复杂图形绘制完成");
                //Console.WriteLine("---------------------");
                //Console.WriteLine();

                //// 移除一个组件再显示复杂图形的画法
                //complexGraphics.Remove(l);
                //Console.WriteLine("移除线段C后，复杂图形的绘制如下：");
                //Console.WriteLine("---------------------");
                //complexGraphics.Draw();
                //Console.WriteLine("复杂图形绘制完成");
                //Console.WriteLine("---------------------");

            }

            {
                //palyerGameFacade palyer = new palyerGameFacade();
                //palyer.palyerLol(100,"icxl");
            }


            {

                ActionProxy proxy = new ActionProxy();

                proxy.chargeMoney(10);
            }
            Console.ReadLine();
        }

    }
}
