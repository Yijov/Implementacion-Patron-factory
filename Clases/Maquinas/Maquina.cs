using Console_Machine_Rentat_System.Clases.Comprobantes;
using Console_Machine_Rentat_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//clase abstracta que determina el layout general de todas las  maquinas
namespace Console_Machine_Rentat_System.Clases
{
    abstract class Maquina: IRentable
    {
        private double precio;
        private string marca;
        
        public Maquina(string marca, double precio)
        {
            this.Marca = marca;
            this.Precio = precio;
        }
        public string Marca { get => marca; set => marca = value; }
        public double Precio { get => precio; set => precio = value; }
        public void rentar() {
            Printer.getPrinter().ImprimirComprobante(new ComprobanteMaquina(this));
        }
       
    }
}
