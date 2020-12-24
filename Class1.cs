using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Enemy
    {
		//注释1222
        public void Move()
        {
            Console.WriteLine("调用了 enemy的move方法");
        }
        public virtual void Attack()
        {
            Console.WriteLine("enemy attac");
        }

      
    }
}
