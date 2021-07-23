
using Console_Machine_Rentat_System.Clases.Proceso;
using Console_Machine_Rentat_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Machine_Rentat_System.Clases
{
    class ProcesoDeRenta : ImputOutput

    {
        private int artculoRentado;
        private string marca;
        private double precioDeRenta;
        public ProcesoDeRenta()
        {
            this.comenzar();

        }

        private void comenzar()
        {
            this.output("Bienvenido!");
            this.ObtenerArticuloARentar();
        }


        private void ObtenerArticuloARentar()
        {
            Console.WriteLine();
            this.output("------------------------------------");
            string mensaje = "Seleccione el articulo que desea rentar y presione ENTER \n" +
                "1) Tractor \n" +
                "2) Grua \n" +
                "3) Retroexcavadora \n" +
                "4) Escalera Hidraulica";

            try
            {
                string input = this.getImput(mensaje);
                this.artculoRentado = int.Parse(input);
                if(this.artculoRentado >4 || this.artculoRentado < 1)
                {
                    this.output("Por favor seleccione Una opcion Valida");
                    this.ObtenerArticuloARentar();

                }
                else
                {
                    this.obtenerMarca();
                }
                
            }
            catch (Exception)
            {
                this.output("Por favor seleccione Una opcion Valida");
                this.ObtenerArticuloARentar();
            }

        }


        private void obtenerMarca()
        {
            Console.WriteLine();
            this.output("------------------------------------");
            string preguntarMarca = "Seleccione la marca deseasda y presione ENTER \n" +
                "1) volvo \n" +
                "2) Troca \n" +
                "3) Caterpila \n" +
                "4) Inca";

            try
            {   
                string input = TraductorDeInputs.traducirMarca(this.getImput(preguntarMarca));
                this.marca = input;
                if (this.marca == "Desconocido")
                {
                    this.output("Por favor seleccione Una opcion Valida");
                    this.obtenerMarca();
                }
                else
                {
                    
                    this.obtenerPrecioDeArticulo();

                }
                
            }
            catch (Exception)
            {
                this.output("Por favor seleccione Una opcion Valida");
                this.obtenerMarca();
            }

        }

        private void obtenerPrecioDeArticulo()
        {
            Console.WriteLine();
            this.output("------------------------------------");
            string mensaje = "Indique el precio al cual va a rentar y prsione EMTER \n";

            try
            {

                string input = this.getImput(mensaje);
                this.precioDeRenta = double.Parse(input);
                this.confirmar();
            }
            catch (Exception)
            {
                output("Debe ingresar un número");
                this.obtenerPrecioDeArticulo();
            }

        }

        private void confirmar()
        {
            Console.WriteLine();
            this.output("------------------------------------");
            Maquina equipoRentado = MaquinaFactory.Crear(this.artculoRentado, this.marca, this.precioDeRenta);
            string input = this.getImput("Usted ha seleccionado un equipo " + equipoRentado.GetType().Name
                + " marca " + equipoRentado.Marca + " por $" +
                equipoRentado.Precio + "\n 1)confirmar \n 2)volver al paso anterior \n 3)Cancelar y salir");
            if (input == "1")
            {
                equipoRentado.rentar();
                this.output("------------  \n su equipo a sido rentado con éxito \n\n Gracias");


            }
            else if (input == "2")
            {
                this.obtenerPrecioDeArticulo();
            }
            else if (input == "3")
            {
                this.output("Hasta Luego");
            }
            else
            {
                this.output("Seleccione una opcion valida");
                this.confirmar();
            }

        }

        
    }
}
