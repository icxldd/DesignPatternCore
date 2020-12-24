using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Facade
{
    public class palyerGameFacade
    {
        private palyerGameVerify palyerGameVerify;
        private NotifyPlayer notifyPlayer;
        public palyerGameFacade()
        {
            palyerGameVerify = new palyerGameVerify();
            notifyPlayer = new NotifyPlayer();
        }

        public void palyerLol(int age, string name)
        {
            if (palyerGameVerify.verifyAge(age))
            {
                Console.WriteLine("你成年啦 可以玩");
                notifyPlayer.Notify(name);
            }
            else
            {
                Console.WriteLine("未成年不可以玩游戏");
            }
        }


    }


    public class palyerGameVerify
    {

        public bool verifyAge(int age)
        {

            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


    }

    public class NotifyPlayer
    {
        public void Notify(string playerName)
        {
            Console.WriteLine("玩家" + playerName + "已上线");
        }
    }
}
