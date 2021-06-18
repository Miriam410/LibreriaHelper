using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHelper
{
    public static class Input
    {
        public static string IngresoTexto(string mensaje = "Ingrese un texto")
        {
            string texto;
            do
            {
                Console.WriteLine(mensaje);
                texto = Console.ReadLine();
            } while (texto == "");

            return texto;
        }

        public static int IngresoNumeroPositivo(string Mensaje = "Ingrese un numero", int max = 1000)
        {
            int numero;
            bool continuar;
            do
            {
                Console.WriteLine(Mensaje);
                continuar = !int.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > max;
                if (continuar)
                {
                    Console.WriteLine("Debe ingresar un numero positivo entre 0 y {0}", max);
                }
            } while (continuar);

            return numero;
        }

        public static double IngresoNumeroDecimal(string Mensaje = "Ingrese un valor", int max = 1000)
        {
            double numero;
            bool continuar;
            do
            {
                Console.WriteLine(Mensaje);
                continuar = !double.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > max;
                if (continuar)
                {
                    Console.WriteLine("Debe ingresar un numero decimal entre 0 y {0}", max);
                }
            } while (continuar);

            return numero;
        }

        public static DateTime IngresoFecha(string Mensaje = "Ingrese una fecha")
        {
            DateTime fecha;
            bool continuar;
            do
            {
                Console.WriteLine(Mensaje);
                continuar = !DateTime.TryParse(Console.ReadLine(), out fecha);
                if (continuar)
                {
                    Console.WriteLine("Ingrese una fecha con el siguiente formato AAAA-MM-DD");
                }
            } while (continuar);

            return fecha;
        }

        public static bool IngresoVerdaderoFalso(string Mensaje = "")
        {
            bool valor;
            bool continuar;
            string helpText = "Ingrese \"Si\" o \"S\" para Si o \"No\" o \"N\" para No";
            do
            {
                Console.WriteLine(Mensaje + "\n" + helpText);
                continuar = !bool.TryParse(
                    Console.ReadLine()
                            .ToLower()
                            .Replace("si", "true")
                            .Replace("s", "true")
                            .Replace("no", "false")
                            .Replace("n", "false")
                            .Replace("0", "false")
                            .Replace("1", "true"), 
                    out valor);
                if (continuar)
                {
                    Console.WriteLine(Mensaje + helpText);
                }
            } while (continuar);

            return valor;
        }

        // 0 – Exit(Salir del programa)
        // Esta opción finalizará la ejecuciòn del programa e informará un mensaje de despedida.
        public static void Exit()
        {
            Console.WriteLine("Hasta pronto!");
            // Console app
            System.Environment.Exit(0);
        }

        public static void Inicio(string nombreAplicacion = "Aplicación")
        {
            Console.WriteLine(""
                + "\t\t**********************************\n"
                + "\t\t\t* {0} *\n"
                + "\t\t**********************************\n\n",
                nombreAplicacion
            );
        }

        public static void Continuar()
        {
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
