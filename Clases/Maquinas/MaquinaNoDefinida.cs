using Console_Machine_Rentat_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* La fabrica retorna esta instancia   en case de que  el usuario seleccione 
un tipo de maquina que no esta en inventario*/

namespace Console_Machine_Rentat_System.Clases
{
    class MaquinaNoDefinida: Maquina
    {
        public MaquinaNoDefinida(string marca, double precio) : base(marca, precio)
        {

        }
     
    }
}
