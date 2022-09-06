using System;

namespace ConsoleAppEjercicio65
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello Prime Numbers!");
                int nroIngresado;
                bool seguir = true;
                //ciclo
                do
                {
                    Console.Write("Ingrese un número positivo:");
                    //Trata de convertir a entero
                    //Si puede pone la conversion en nroIngresado
                    if (!int.TryParse(Console.ReadLine(), out nroIngresado))
                    {
                        //si no puede convertir muestra mensaje de error
                        Console.WriteLine("Nro mal ingresado");
                    }
                    else if (nroIngresado <= 0)//Veo si el nro es >0
                    {
                        Console.WriteLine("El nro debe ser positivo");
                    }
                    else
                    {
                        seguir=false;//es la forma de salir del ciclo
                    }

                } while (seguir);

                if (EsPrimo(nroIngresado))
                {
                    Console.WriteLine($"{nroIngresado} es primo");
                }
                else
                {
                    Console.WriteLine($"{nroIngresado} no es primo");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Se produjo un error");
            }
            Console.ReadLine();
        }

        private static bool EsPrimo(int nro)
        {
            //int cantidadDivisores = 2;
            //for (int i = 2; i < (int)Math.Truncate((double)nro/2); i++)
            //{
            //    if (nro%i==0)
            //    {
            //        cantidadDivisores++;
            //    }
            //}

            //return cantidadDivisores == 2;
            for (int i = 2; i < (int)Math.Truncate((double)nro / 2); i++)
            {
                if (nro % i == 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
