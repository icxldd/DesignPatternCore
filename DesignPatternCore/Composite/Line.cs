using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCore.Composite
{
    public class Line : Graphics
    {

        public Line(string name, int x, int y) : base(name, x, y)
        {

        }
        public override void Add(Graphics g)
        {
            throw new Exception("不能向简单图形Line添加其他图形");
        }

        public override void Draw()
        {
            Console.WriteLine($"在x:{x},y:{y}位置开始画线${name}");
        }

        public override void Remove(Graphics g)
        {
            throw new Exception("不能向简单图形Line添加其他图形");
        }
    }
}
