using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Adapter
{
    public class PowerAdapter : B
    {
        private A a = new A();
        public override void request()
        {
            a.request();
            base.request();
        }
    }
}
