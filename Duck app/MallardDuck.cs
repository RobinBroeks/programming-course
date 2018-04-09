using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_app
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public void display()
        {
            Console.WriteLine();
        }
    }
}
