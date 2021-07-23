using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Machine_Rentat_System.Clases.Comprobantes
{
    class ComprobanteMaquina : Comprobante
    { 
        private string equipo;
        private string marca;
        private double precio;
        public string Equipo { get => equipo; set => equipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Precio { get => precio; set => precio = value; }

        public ComprobanteMaquina(Maquina maquina) : base(maquina)
        {
            this.Encabezado = "*****Comprobante de renta de equipo pesaso*****";
            this.Equipo = maquina.GetType().Name;
            this.Marca = maquina.Marca;
            this.Precio = maquina.Precio;
        }
        public override string getComprobante()
        {
            string jumpline = "\n";
            string linea1 = this.Encabezado + jumpline;
            string linea2 = "Equipo rentado: " + this.Equipo + jumpline;
            string linea3 = "Marca: "+ this.Marca + jumpline;
            string linea4 = "Precio: " + this.Precio +  jumpline;
            string linea5 = "Fecha: "+ this.Fecha + jumpline;
            string linea6 = "Hora: " + this.Hora;
            string printable = jumpline + linea1 + linea2 + linea3 + linea4 + linea5 + linea6;
            return printable;
        }
    }
}
