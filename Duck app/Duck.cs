using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_app
{
    public class Duck 
    {
        FlyBehavior flyBehavoir;
        QuackBehavior quackBehavior;

        public Duck()
        {

        }

        public void display()
        {

        }

        public void performFly()
        {
            flyBehavoir.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("all ducks float");
        }
    }
}
