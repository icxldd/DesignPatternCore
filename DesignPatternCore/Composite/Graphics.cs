using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Composite
{



    /// <summary>
    /// 图形抽象类
    /// </summary>
    public abstract class Graphics
    {

        public string name { get; set; }
        public int x { get; set; }
        public int y { get; set; }


        public Graphics(string name)
        {
            this.name = name;
        }

        public Graphics(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public abstract void Draw();
        public abstract void Add(Graphics g);
        public abstract void Remove(Graphics g);

    }
}
