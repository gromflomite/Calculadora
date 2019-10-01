using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSelection;
            double userNum1, userNum2;

            do
            {                
                Console.WriteLine("\n\t **** CALCULADORA **** \n\t 1. Suma \n\t 2. Resta \n\t 3. Multiplicación \n\t 4. Potencia \n\t 5. División \n\t 6. Raiz \n\t 7. Salir");

                Console.Write("\n\t Seleccione una opción: ");
                userSelection = Convert.ToInt32(Console.ReadLine());                

                switch (userSelection)
                {
                    case 1:
                        Console.Write("\n\t Introduzca el primer número: ");
                        userNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\n\t Introduzca el segundo número: ");
                        userNum2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"\n\t Ha seleccionado sumar sus números. \n\t Número 1: {userNum1} y número 2: {userNum2}");
                        Console.WriteLine("\n\t El resultado de su operación es: " + (userNum1 + userNum2));
                        break;

                    case 2:
                        Console.Write("\n\t Introduzca el primer número: ");
                        userNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\n\t Introduzca el segundo número: ");
                        userNum2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"\n\t Ha seleccionado restar sus números. \n\t Número 1: {userNum1} y número 2: {userNum2}");
                        Console.WriteLine("\n\t El resultado de su operación es: " + (userNum1 - userNum2));
                        break;

                    case 3:
                        Console.Write("\n\t Introduzca el primer número: ");
                        userNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\n\t Introduzca el segundo número: ");
                        userNum2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"\n\t Ha seleccionado multiplicar sus números. \n\t Número 1: {userNum1} y número 2: {userNum2}");
                        Console.WriteLine("\n\t El resultado de su operación es: " + (userNum1 * userNum2));
                        break;

                    case 4:
                        Console.Write("\n\t Introduzca el primer número: ");
                        userNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\n\t Introduzca el segundo número: ");
                        userNum2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"\n\t Ha seleccionado aplicar potenciación a sus números. \n\t Número 1: {userNum1} y número 2: {userNum2}");
                        Console.WriteLine("\n\t El resultado de su operación es: " + (Math.Pow(userNum1, userNum2)));
                        break;

                    case 5:
                        Console.Write("\n\t Introduzca el primer número: ");
                        userNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\n\t Introduzca el segundo número: ");
                        userNum2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"\n\t Ha seleccionado dividir sus números. \n\t Número 1: {userNum1} y número 2: {userNum2}");
                        Console.WriteLine("\n\t El resultado de su operación es: " + (userNum1 / userNum2));
                        break;

                    case 6:
                        Console.Write("\n\t Introduzca el número: ");
                        userNum1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"\n\t Ha seleccionado calcular la raiz cuadradada. \n\t Número 1: {userNum1}");
                        Console.WriteLine("\n\t El resultado de su operación es: " + (Math.Sqrt(userNum1)));
                        break;

                    case 7:
                        Console.WriteLine("\n\t Aplicación terminada.");
                        break;

                    default:
                        Console.WriteLine("\n\t La opción seleccionada no es correcta.");
                        break;
                }
            } while (userSelection != 7);
        }
    }
}