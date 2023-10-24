//Estudiante: José Pablo Muñoz Zúñiga 
//Carrera: Ingeniería Informática
//Materia: Programación II
//Ejercicio: Primer examen de programación II

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

//En esta parte es el nombre del programa

namespace Primer_Examén_de_Programación_II
{
    //En esta parte estan los datos de los empleados requeridos
    internal class Clsempleados
    {
        // Atributos
        static int cant = 3;
        static byte indice = 0;
        static int posicion = 1;
        static string[] cedula = new string[cant];
        static string[] nombre = new string[cant];
        static string[] direccion = new string[cant];
        static string[] telefono = new string[cant];
        static int[] salario = new int[cant];


        //Metodos

        //En esta parte el usuario puede agregar a los empleados que desea
        public static void agregarempleados()
        {
            //En esta parte es para calcular, si un salario de un empleado es mas alto o el mas bajo, y ordenar todos los salarios de los empleados 

            char respuesta = 'S';

            //En esta parte es donde se agregan nuevos datos de un empleado

            while (!respuesta.Equals('N') && (posicion <= cant))
            {
                //En esta parte se agrega la nueva cedula de un empleado 
                Console.Write("Digite la cedula del empleado {0}: ", posicion);
                cedula[indice] = Console.ReadLine();
                //En esta parte se agrega el nuevo nombre de un empleado 
                Console.Write("Digite el nombre del empleado {0}:", posicion);
                nombre[indice] = Console.ReadLine();
                //En esta parte se agrega la nueva direccion de un empleado
                Console.Write("Digite la direccion del empleado {0}:", posicion);
                direccion[indice] = Console.ReadLine();
                //En esta parte se agrega el nuevo telefono de un empleado
                Console.Write("Digite el telefono del empleado {0}:", posicion);
                telefono[indice] = Console.ReadLine();
                //En esta parte se agrega el nuevo salario de un empleado 
                Console.Write("Digite el salario del empleado {0}: ", posicion);
                int.TryParse(Console.ReadLine(), out salario[indice]);
                indice++;
                posicion++;
                //En esta parte es donde si el usuario desea ingresar a otro estudiante
                Console.WriteLine("Desea ingresar otro estudiante S/N");
                respuesta = char.Parse(Console.ReadLine().ToUpper());

            }

        }

        //En este menu el usuario puede consultar a todos los empleados que digito
        public static void consultarempleados()
        {
            //En esta parte es donde el usuario puede ver a todos los empleados consultados
            Console.WriteLine("********** CONSULTAR EMPLEADOS **********");
            for (int i = 0; i < posicion - 1; i++)
            {
                Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]} ");
            }
            //En esta es donde la consulta de los empleados llega a su fin
            Console.WriteLine("********** FIN DE LA CONSULTA ***********");
            //En esta parte es para que esta opcion del menu principal funcione
            Console.ReadLine();
            Console.Clear();
        }

        //En esta parte el usuario puede modificar a los empleados que desea
        public static void modificarempleados()
        {

            {

                string respuesta = "";
                bool buscar = false;


                //En esta parte se digita la cedula de un empleado para ser modificada
                Console.WriteLine("Digite la cedula del empleado {0}: ", posicion);
                //En esta parte se modifica el nombre de un empleado para ser modificado
                cedula[indice] = Console.ReadLine();
                Console.WriteLine("Digite el nombre del empleado {0}:", posicion);
                nombre[indice] = Console.ReadLine();
                //En esta parte se digita la direccion de un empleado para ser modificado
                Console.WriteLine("Digite la direccion del empleado {0}:", posicion);
                direccion[indice] = Console.ReadLine();
                //En esta parte se digita el telefono de un empleado para ser modificado
                Console.WriteLine("Digite el telefono del empleado {0}: ", posicion);
                telefono[indice] = Console.ReadLine();
                //En esta parte se digita el salario de un empleado para ser modificado
                Console.WriteLine("Digite el salario del empleado {0}: ", posicion);
                int.TryParse(Console.ReadLine(), out salario[indice]);
                indice++;
                posicion++;
                Console.WriteLine("Presione una tecla para continuar");
                Console.WriteLine("Presione por segunda vez una tecla para continuar");

                respuesta = Console.ReadLine();
                //En esta parte es para que todos los datos de los empleados que luego seran modificados
                for (int i = 0; i < cant; i++)
                {
                    if (respuesta.Equals("SI"))
                    {
                        cedula[i] = "";
                        nombre[i] = "";
                        direccion[i] = "";
                        telefono[i] = "";
                        salario[i] = 0;
                        buscar = true;
                        break;


                    }
                }

                //En esta parte es cuando el usuario intento modificar a un empleado que no existe
                if (!buscar == false)
                {
                    Console.WriteLine("El empleado que digito no existe");
                }
                //En esta parte es para es que esta opcion del menu principal funcione
                Console.ReadLine();
                Console.Clear();

            }

        }

        //En esta parte el usuario puede borrar a los empleados que desea pero uno a la vez

        public static void borrarempleados()
        {
            //En esta parte el usuario digita el nombre de un empleado para ser eliminado
            Console.Write("Digite el nombre del empleado que desea eliminar: ");
            string nomb = Console.ReadLine();
            //En esta parte el empleado que fue digitado por el usuario fue eliminado
            Console.WriteLine("El empleado fue eliminado");
            //En esta parte tiene la funcion de regresar al menu principal por la tecla ENTER
            Console.Write("Presiona La tecla ENTER para regresar al menu");
            Boolean existe = false;
            //En esta parte son todos los datos de un empleado que luego seran eliminados
            for (int i = 0; i < cant; i++)
            {
                if (nomb.Equals(nombre[i]))
                {
                    cedula[i] = "";
                    nombre[i] = "";
                    direccion[i] = "";
                    telefono[i] = "";
                    salario[i] = 0;
                    existe = true;
                    break;
                }
            }

            //En esta parte es cuando el usuario intento borrar a un empleado que no existe
            if (!existe)
            {
                Console.WriteLine("El empleado que digito no existe");
            }
            //En esta parte es para que esta opcion del menu principal funcione
            Console.ReadLine();
            Console.Clear();
        }

        //En esta parte el usuario puede borrar a todos los empleados a la vez
        public static void inicializararreglos()
        {
            //En esta parte es para que todos los datos de los empleados digitados se borren
            cedula = Enumerable.Repeat("", cant).ToArray();
            nombre = Enumerable.Repeat("", cant).ToArray();
            direccion = Enumerable.Repeat("", cant).ToArray();
            telefono = Enumerable.Repeat("", cant).ToArray();
            salario = Enumerable.Repeat(0, cant).ToArray();
            posicion = 1;
            indice = 0;
            Console.Clear();
            //En esta parte los arreglos quedan inicializados teniendo la funcion de borrar a todos los empleados
            Console.WriteLine("Arreglos inicializados");
            //En esta parte tiene la funcion de regresar al menu principal por la tecla ENTER
            Console.Write("Presiona La tecla ENTER para regresar al menu");
            //En esta parte es para que esta opcion del menu principal funcione
            Console.ReadLine();
        }

        //En esta parte el usuario puede consultar de un empleado por numero de cedula
        public static void Consultarempleadosconnumerodecedula()
        {
            //En esta parte el usuario digito la cedula de un empleado para ser consultado
            Console.WriteLine("Digite la cedula del empleado: ", posicion);
            string nomb = Console.ReadLine();
            Boolean existe = false;

            //En esta parte se ve todos los datos de un empleado al ser consultado
            for (int i = 0; i < cant; i++)
            {
                if (nomb.Equals(cedula[i]))
                {
                    Console.WriteLine($"Cedula del empleado: {cedula[i]} Nombre del empleados: {nombre[i]} Direccion del empleado: {direccion[i]} Telefono del empleado: {telefono[i]} Salario del empleado: {salario[i]} ");
                    existe = true;
                    break;
                }
            }

            //En esta parte es si el usuario digito a un empleado que no existe
            if (!existe)
            {
                Console.WriteLine("El empleado que digito no existe");
            }
            //En esta parte es para que esta opcion del submenu funcione
            Console.ReadLine();
            Console.Clear();
        }

        //En esta parte el usuario puede ver la lista de todos los empleados

        public static void Listartodoslosempleados()
        {
            //En esta parte es la lista de todos los empleados
            Console.WriteLine("********** Listar todos los empleados **********");
            for (int i = 0; i < posicion - 1; i++)
            {
                Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
            }
            //En esta parte de dejo de listar a todos los empleados
            Console.WriteLine("********** SE DEJO DE LISTAR A LOS EMPLEADOS **********");
            //En esta parte es para que esta opcion del submenu funcione
            Console.ReadLine();
            Console.Clear();
        }

        //En esta parte puede calcular y mostrar el promedio de los salarios
        public static void Calcularymostrarelpromediodelossalarios()
        {
            {
                //En esta parte se muestra los promedios de los salarios de los empleados
                Console.WriteLine("************** CALCULAR Y MOSTRAR EL PROMEDIO DE LOS SALARIOS DE LOS EMPLEADOS ************");

                for (int i = 0; i < posicion - 1; i++)
                {
                    Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                }
                //En esta parte se dejo de mostrar los promedios de los salarios de los empleados
                Console.WriteLine("********** SE DEJO DE MOSTRAR EL PROMEDIO DE LOS SALARIOS DE LOS EMPLEADOS **********");

                //En esta parte el usuario para continuar debe presionar una tecla

                Console.WriteLine("Si deseas continuar presione una la tecla ");
                {
                    string continuar = Console.ReadLine();
                    Continuacion(continuar);

                    Console.ReadLine();
                }

                //En esta parte el usuario para continuar para sumar el promedio de los salarios de los empleados debe presionar una tecla otra vez

                //Metodo: tipo de dato retorno + parametros

                void Continuacion(string continuar)
                {
                    Console.WriteLine("Deseas sumar el promedio de los salarios de los empleados presione una tecla");

                }

                int s1, s2, s3, Tc, P;
                //En esta parte el usuario digita el salario del primer empleado
                Console.WriteLine("Digite el primer salario: ");
                //En esta parte el usuario digita el salario del segundo empleado
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el segundo salario: ");
                //En esta parte el usuario digita el salario del tercer empleado
                s2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el tercer salario: ");
                s3 = Convert.ToInt32(Console.ReadLine());
                Tc = s1 + s2 + s3;
                P = Tc / 3;
                //En esta parte se saca el total de los salarios de los empleados
                Console.WriteLine("El total de los salarios es {0}", Tc);
                //En esta parte se saca el promedio de los salarios de los empleados
                Console.WriteLine("El promedio de los salarios es {0},", P);
                //En esta parte es para que esta opcion del submenu funcione
                Console.ReadLine();
                Console.Clear();
            }

        }

        //En esta parte el usuario puede calcular y mostrar el salario mas alto y el mas bajo de todos los empleados
        public static void Calcularymostrarelsalariomasaltoyelmasbajodetodoslosempleados()
        {
            //En esta parte se muestra cual es el salario mas alto y el mas bajo de cada empleado
            Console.WriteLine("************ CALCULAR Y MOSTRAR EL SALARIO MAS ALTO Y EL MAS BAJO DE TODOS LOS EMPLEADOS ************");
            for (int i = 0; i < posicion - 1; i++)
            {
                Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
            }
            //En esta parte se finalizo la muestra de cual salario de los empleados es el mas alto y el mas bajo de cada empleado
            Console.WriteLine("************ SE DEJO DE CALCULAR Y MOSTRAR EL SALARIO Y EL MAS BAJO DE TODOS LOS EMPLEADOS **********");

            //En esta parte se muestra cual es el salario mas alto y el mas bajo de todos los empleados

            int[] listaNumeros = new int[3];
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                //En esta parte se ingresa el salario de cada empleado 
                Console.WriteLine("Ingrese el salario de cada empleado: " + (i + 1));
                listaNumeros[i] = int.Parse(Console.ReadLine());
            }

            int menor = 0;
            int pos = 0;
            int tem = 0;

            for (int i = 0; i < listaNumeros.Length - 1; i++)
            {
                menor = listaNumeros[i];
                pos = i;

                for (int j = i + 1; j < listaNumeros.Length; j++)
                {
                    if (listaNumeros[j] < menor)
                    {
                        menor = listaNumeros[j];
                        pos = j;
                    }

                    if (pos != i)
                    {
                        tem = listaNumeros[i];
                        listaNumeros[i] = listaNumeros[pos];
                        listaNumeros[pos] = tem;
                    }
                }
            }

            //En esta parte los salarios de los empleados han sido ordenados

            Console.WriteLine("Los salarios de los empleados han sido ordenados");
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }

            Console.Read();

            //En esta parte es para que esta opcion del submenu funcione
            Console.ReadLine();
            Console.Clear();


        }


        //En esta parte es la responsable de que el menu se ejecute correctamente
        static void Main(string[] args)
        {
            Clsmenu.Desplegar();
        }

    }
}