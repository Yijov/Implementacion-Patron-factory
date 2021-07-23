using Console_Machine_Rentat_System.Clases.Comprobantes;
using Console_Machine_Rentat_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Machine_Rentat_System.Clases
{
    class Printer
    {
        private static Printer instance;
        private Printer()
        {
        }
        public void ImprimirComprobante(Comprobante comprobante)
        {
            Console.WriteLine(comprobante.getComprobante());
        }
        public static Printer getPrinter()
        {
           
            if (instance == null)
            {
                instance = new Printer();
            }
            return instance;
        }
    }
}
