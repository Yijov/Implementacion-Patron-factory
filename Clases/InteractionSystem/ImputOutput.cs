using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Console_Machine_Rentat_System.Clases
{
    class ImputOutput
    {
       public string getImput(string rerquest)
        {
            Console.WriteLine(rerquest);
            return Console.ReadLine();
        }
       public void output(string message)
        {
            Console.WriteLine(message);
        }
    }
}
//permite recivir y dar informacion con el usuario