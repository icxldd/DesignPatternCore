using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Factory.factoryMethod
{
    public class sqlServerFactory : Creator
    {
        public override ORMBasic CreateORMFactory()
        {
            return new SqlServerORMProvider();
        }
    }
}
