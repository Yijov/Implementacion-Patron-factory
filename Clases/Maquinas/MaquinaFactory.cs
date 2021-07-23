using Console_Machine_Rentat_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Machine_Rentat_System.Clases
{
    class MaquinaFactory
    {
        public const int TRACTOR = 1;
        public const int GRUA = 2;
        public const int RETROEXCAVADORA = 3;
        public const int ESCALERAHIDRAULICA = 4;
        public static Maquina Crear(int Tipo, string marca, double precio)
        {
            switch (Tipo)
            {
                case 1:
                    return new Tractor(marca, precio);
                    
                case 2:
                    return new Grua(marca, precio);
                   
                case 3:
                    return new Retroexcavadora(marca, precio);
                   
                case 4:
                    return new EscaleraHidraulica(marca, precio);
                    
                default:
                    return new MaquinaNoDefinida(marca, precio);
                   
            }
        }
    }
}