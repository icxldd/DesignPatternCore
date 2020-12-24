using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Bridge
{
    public class sqlServerProvider : ORMBasic
    {
        public void add()
        {
            Console.WriteLine($"SqlServerORMProvider->{nameof(add)}");
        }

        public void delete()
        {
            Console.WriteLine($"SqlServerORMProvider->{nameof(delete)}");
        }

        public void select()
        {
            Console.WriteLine($"SqlServerORMProvider->{nameof(select)}");
        }

        public void update()
        {
            Console.WriteLine($"SqlServerORMProvider->{nameof(update)}");
        }
    }
}
