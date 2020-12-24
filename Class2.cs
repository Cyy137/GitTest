using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Boss : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Boss Attac");
        }

        public new void Move()
        {
            Console.WriteLine("Boss move");
        }
    }

}
