using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Factory.factoryMethod
{
    public abstract class Creator
    {
        public abstract ORMBasic CreateORMFactory();
    }


}
