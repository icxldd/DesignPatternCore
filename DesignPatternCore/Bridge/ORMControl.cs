using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Bridge
{
    public class ORMControl
    {
        private ORMBasic _ormBasic = null;

        public ORMControl(ORMBasic orm)
        {
            _ormBasic = orm;
        }

        public void add()
        {
            _ormBasic.add();
        }

        public void delete()
        {
            _ormBasic.delete();
        }

        public void select()
        {
            _ormBasic.select();
        }

        public void update()
        {
            _ormBasic.update();
        }


    }
}
