using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Machine_Rentat_System.Clases.Proceso
{
    class TraductorDeInputs
    {
        static public string traducirMarca(string input )
        /*
        "1) volvo \n" +
        "2) Troca \n" +
        "3) Caterpila \n" +
        4) Inca";
        */
        {
            if (input== "1")
            {
                return "Volvo";
            }else if(input == "2")
            {
                return "Troca";
            }
            else if (input == "3")
            {
                return "Caterpilar";
            }
            else if (input == "4")
            {
                return "Inca";
            }
            else
            {
                return "Desconocido";
            }
        }
       
    
    }
}


