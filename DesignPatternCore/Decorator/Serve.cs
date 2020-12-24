using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Decorator
{
    /// <summary>
    /// 服务抽象类
    /// </summary>
    public abstract class Serve
    {
        public abstract void Print();
    }

    public abstract class ServeDecorator : Serve
    {
        private Serve _serve;

        public ServeDecorator(Serve p)
        {
            this._serve = p;
        }

        public override void Print()
        {
            if (_serve != null)
            {
                _serve.Print();
            }
        }
    }

    /// <summary>
    /// 丑陋的
    /// </summary>
    public class uglyServeDecorator : ServeDecorator
    {
        public uglyServeDecorator(Serve p)
          : base(p)
        {
        }

        public override void Print()
        {
            base.Print();

            // 添加新的行为
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("增加丑陋的特性");
        }
    }


    public class niceServeDecorator : ServeDecorator
    {
        public niceServeDecorator(Serve p)
          : base(p)
        {
        }

        public override void Print()
        {
            base.Print();

            // 添加新的行为
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("增加好看的特性");
        }
    }





    public class invincibleServeDecorator : ServeDecorator
    {
        public invincibleServeDecorator(Serve p)
          : base(p)
        {
        }

        public override void Print()
        {
            base.Print();

            // 添加新的行为
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("增加无敌的特性");
        }
    }



    public class manServe : Serve
    {
        public override void Print()
        {
            Console.WriteLine("男生Serve");
        }
    }


    public class woManServe : Serve
    {
        public override void Print()
        {
            Console.WriteLine("女生Serve");
        }
    }




}
