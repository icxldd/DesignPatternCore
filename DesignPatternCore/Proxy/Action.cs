using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Proxy
{

    /// <summary>
    /// 抽象行为
    /// </summary>
    public abstract class Action
    {
        public abstract void chargeMoney(int count);
    }


    public class RealAction : Action
    {
        public override void chargeMoney(int count)
        {
            Console.WriteLine($"充值${count}元");
        }
    }



    public class ActionProxy : Action
    {
        private RealAction realSubject = new RealAction();
        public override void chargeMoney(int count)
        {
            preChargeMoney();

            realSubject.chargeMoney(count);

            afterChargeMoney();

        }

        private void preChargeMoney()
        {
            Console.WriteLine("充钱前");
        }

        private void afterChargeMoney()
        {
            Console.WriteLine("充钱后");
        }
    }

}
