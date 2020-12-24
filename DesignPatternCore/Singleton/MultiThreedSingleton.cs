using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Singleton
{
    //v1
    public class MultiThreedSingleton
    {

        private static MultiThreedSingleton _singleton;


        private static readonly object locker = new object();
        private MultiThreedSingleton()
        {

        }

        public static MultiThreedSingleton GetInstance()
        {
            if (_singleton == null)
            {
                lock (locker)
                {
                    if (_singleton == null)
                    {
                        _singleton = new MultiThreedSingleton();
                    }

                }
            }
            return _singleton;
        }

    }
}
