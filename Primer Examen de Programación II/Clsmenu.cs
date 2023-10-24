

//Estudiante: José Pablo Muñoz Zúñiga
//Carrera: Ingeniería Informática
//Materia: Programación II
//Ejercicio: Primer examen de programación II

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En esta parte es el nombre del programa

namespace Primer_Examén_de_Programación_II
{
    //En esta parte el usuario tiene un menu donde puede elegir la opcion que desea
    internal class Clsmenu
    {

        // Atributos

        static int opcion = 0; // global

        //En esta parte el usuario puede elegir la opcion que desea en el menu
        public static void Desplegar()
        {
            //En esta parte hay siete opciones de las cuales el usuario puede elegir
            int num = 0; // local
            opcion = 6;
            do
            {
                Console.WriteLine("1-Agregar Empleados");
                Console.WriteLine("2-Consultar Empleados");
                Console.WriteLine("3-Modificar Empleados");
                Console.WriteLine("4-Borrar Empleados");
                Console.WriteLine("5-Inicializar Arreglos");
                Console.WriteLine("6-Reportes");
                Console.WriteLine("7.Salir");
                Console.WriteLine("Digite una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                //En esta parte es para que las del menu principal funcione

                switch (opcion)
                {
                    case 1: Clsempleados.agregarempleados(); break;
                    case 2: Clsempleados.consultarempleados(); break;
                    case 3: Clsempleados.modificarempleados(); break;
                    case 4:
                        Clsempleados.borrarempleados();
                        break;
                    case 5:
                        Clsempleados.inicializararreglos();
                        break; ;
                    case 6: Submenu(); break;
                    case 7: break;
                    default:
                        break;
                }


            } while (opcion != 7);
        }

        //En esta parte el usuario al ingresar a la opcion seis del menu anterior entra a un submenu donde puede elegir la opcion que desea
        public static void Submenu()
        {
            //En esta parte el usuario puede elegir en este submenu la opcion que desea
            int num = 0; // local
            opcion = 5;
            do
            {
                //En esta parte el usuario puede elegir si de las cinco opciones cual desea
                Console.Clear();
                Console.WriteLine("1. Consultar empleados por numero de cedula");
                Console.WriteLine("2. Listar todos los empleados");
                Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4. Calcular y mostrar el salario más alto y bajo de todos los empleados");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Digite una opcion");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    //En esta parte es para que el submenu funcione
                    case 1: Clsempleados.Consultarempleadosconnumerodecedula(); break;
                    case 2: Clsempleados.Listartodoslosempleados(); break;
                    case 3: Clsempleados.Calcularymostrarelpromediodelossalarios(); break;
                    case 4: Clsempleados.Calcularymostrarelsalariomasaltoyelmasbajodetodoslosempleados(); break;
                    case 5: break;

                    default:
                        break;

                }
            } while (opcion != 5);
        }
    }
}