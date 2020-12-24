using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Bridge
{
    public interface ORMBasic
    {
        void add();

        void delete();

        void update();

        void select();
    }
}
