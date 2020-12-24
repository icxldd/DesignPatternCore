using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Singleton
{
    public class SingleThreedSingleton
    {
        private static SingleThreedSingleton _singleton;

        private SingleThreedSingleton()
        {

        }

        public static SingleThreedSingleton GetInstance()
        {
            if (_singleton == null)
            {
                _singleton = new SingleThreedSingleton();
                return _singleton;
            }
            else {
                return _singleton;
            }
        }

    }
}
