using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Factory
{


    public enum eORMProvider
    {
        sqlServer,
        mySql
    }

    public interface ORMBasic
    {
        void add();

        void select();

        void delete();

        void update();

    }
}
