using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Factory.abstractFactory
{
    public abstract class BasicFactory
    {
        public abstract ORMBasic CreateORM();
    }
}
