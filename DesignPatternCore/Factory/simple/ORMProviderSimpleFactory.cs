using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Factory
{
    public class ORMProviderSimpleFactory
    {
        private ORMProviderSimpleFactory() { }

        public static ORMBasic CreateORMProvider(eORMProvider e)
        {
            ORMBasic rOrm = null;
            switch (e)
            {
                case eORMProvider.sqlServer:

                    rOrm = new SqlServerORMProvider();
                    break;
                case eORMProvider.mySql:
                    rOrm = new MysqlORMProvider();
                    break;
                default:
                    break;
            }
            return rOrm;
        }

    }
}
