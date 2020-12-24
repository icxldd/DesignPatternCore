using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Bridge
{
    public class MySqlProvider : ORMBasic
    {
        public void add()
        {
            Console.WriteLine($"MysqlORMProvider->{nameof(add)}");
        }

        public void delete()
        {
            Console.WriteLine($"MysqlORMProvider->{nameof(delete)}");
        }

        public void select()
        {
            Console.WriteLine($"MysqlORMProvider->{nameof(select)}");
        }

        public void update()
        {
            Console.WriteLine($"MysqlORMProvider->{nameof(update)}");
        }
    }
}
