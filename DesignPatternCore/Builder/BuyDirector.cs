using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Builder
{
    /// <summary>
    /// 老板
    /// </summary>
    public class BuyDirector
    {
        public void Buy(BuyBuilder build)
        {
            build.buyDress();
            build.buySupplies();
        }
    }
}
