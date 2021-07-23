using Console_Machine_Rentat_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Machine_Rentat_System.Clases.Comprobantes
{
    abstract class Comprobante
    {
        private string encabezado;
        private string fecha;
        private string hora;
        public string Encabezado { get => encabezado; set => encabezado = value; }
        
        public string Hora { get => hora; set => hora = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        

        public Comprobante(IRentable equipoRentado)
        {
            this.Fecha = DateTime.UtcNow.ToString("dd.MM.yyy");
            this.Hora = DateTime.Now.ToString("h:mm tt");
        }

        public abstract string getComprobante();
        
    }

}
