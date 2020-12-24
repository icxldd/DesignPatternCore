﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Factory.abstractFactory
{
    public class sqlServerFactory : BasicFactory
    {
        public override ORMBasic CreateORM()
        {
            return new SqlServerORMProvider();
        }
    }
}
