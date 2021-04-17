using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1,'#');
            p1.Draw();

            Point p2 = new Point(2,2,'*');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(0,10,7,'*');
            line.Draw();

            VerticalLine vline = new VerticalLine(0, 10, 10, '#');
            vline.Draw();



            Console.ReadLine();
        } 

        
    }
}
