using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
   
    internal class SmartPot
    {
        public event Kitchen OnDishReady;
        public  void StartCooking(string dish, int min)
        {

            for (int i = 0; i < min; i++) 
            {
                Console.WriteLine("עברה דקה מזמן הבישול");
            }
               
         Console.WriteLine("זמן הבישול הסתיים");
            OnDishReady?.Invoke(dish, min);
        }
        
    }
}
