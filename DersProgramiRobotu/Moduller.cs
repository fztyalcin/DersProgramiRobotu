using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiRobotu
{
    public class Moduller
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public void ModulYaz()
        {
            Console.WriteLine("Modül Adı :" + Ad + "\nModüle Girebilecek Branşlar :" + Brans);
        }
    }
    

    
}

