using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public delegate void Kitchen(string nameM, int mineth);
       
        static void Main(string[] args)
        {
            SmartPot sp=new SmartPot();
            Chef cf=new Chef();

            sp.OnDishReady += cf.TakeOffStove;
            sp.OnDishReady += (dish, min) => Console.WriteLine("צפצוף אזהרה");


            sp.StartCooking("עוף", 2);
           
            sp.OnDishReady -= cf.TakeOffStove;
            sp.StartCooking("עוף", 2);
        }
    }
}
