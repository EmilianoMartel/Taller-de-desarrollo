using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Ejercicio1
{
    public class Ejercicios
    {
        public void Ejercicio1()
        {
            /*Ingrese un número si es 0 muestre el siguiente mensaje 
             * “El número ingresado es 0” y sinó muestre elsiguiente mensaje 
             * “El número ingresado no es 0”.*/
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = VerifyIntegerInput();

            if (num == 0)
            {
                Console.WriteLine("El numero ingresado es 0.");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es 0");
            }
        }

        public void Ejercicio2()
        {
            /*Pida un número y diga si es positivo o negativo.*/
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = VerifyIntegerInput();

            if (num >= 0)
            {
                Console.WriteLine("El numero ingresado es positivo.");
            }
            else
            {
                Console.WriteLine("El numero ingresado es negativo.");
            }
        }

        public void Ejercicio3()
        {
            /*Pida un carácter y si es igual a ‘s’ mostrar por pantalla 
             * “Ha elegido salir del juego, si es igual a ‘n’,mostrar por pantalla 
             * “Ha elegido seguir divirtiéndose!”.*/
            string exit;
            Console.WriteLine("Desea salir? S/N ");
            exit = Console.ReadLine();
            do
            {
                if (exit.ToLower() == "s")
                {
                    Console.WriteLine("Ha elegido salir del juego");
                }
                else if (exit.ToLower() == "n")
                {
                    Console.WriteLine("Ha elegido seguir divirtiéndose!");
                }
                else
                {
                    Console.WriteLine("Acceso invalido, intentelo nuevamente: ");
                    exit = Console.ReadLine();
                }
            } while (exit.ToLower() != "s" || exit.ToLower() != "n");
        }

        public void Ejercicio4()
        {
            /*Pida tres números e indicar si el tercero es 
             * igual a la suma del primero y el segundo.*/
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Escriba el primer numero");
            num1 = VerifyIntegerInput();
            Console.WriteLine("Escriba el segundo numero");
            num2 = VerifyIntegerInput();
            Console.WriteLine("Escriba el tercer numero");
            num3 = VerifyIntegerInput();
            if (num1 + num2 == num3)
            {
                Console.WriteLine("La suma de los dos pimeros numeros es el 3er numero.");
            }
            else
            {
                Console.WriteLine("La suma de los dos pimeros numeros no es el 3er numero.");
            }
        }

        public void Ejercicio5()
        {
            /*Declarar una variable llamada puedeDisparar = true, 
             * y pedirle al usuario que le de un valor a la variableentera “código”. 
             * Sólo entrará a la condición si puedeDisparar es true y código es igual a 2. 
             * Imprimir porpantalla “Puede disparar ya que adivinó el código”*/
            bool puedeDisparar = true;
            int codigo;

            Console.WriteLine("Introduzca un valor numerico para el codigo: ");
            codigo = VerifyIntegerInput();
            if (puedeDisparar && codigo == 2)
            {
                Console.WriteLine("Puede disparar ya que adivinó el código");
            }
        }

        public void Ejercicio6()
        {
            /*Ingrese dos números, saque el promedio entre los mismos y muéstrelo en pantalla.
             * Si promedio esmenor a 1, en vez de mostrar el promedio simplemente muestre 
             * el siguiente mensaje “El promedio es muybajo”*/
            int num1;
            int num2;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = VerifyIntegerInput();
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = VerifyIntegerInput();
            if ((num1+num2)/2 >= 1)
            {
                Console.WriteLine("El promedio es: " + (num1 + num2) / 2);
            }
            else
            {
                Console.WriteLine("El promedio es muy bajo");
            }
        }

        public void Ejercicio7()
        {
            /*Ingrese un número, si es mayor a 45, menor a 500 y no es el 84 imprima en pantalla 
             *el siguientemensaje “El número ingresado es válido”, si no, 
             *imprima en pantalla el mensaje “El valor ingresado no esválido”.
             */
            int num1;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = VerifyIntegerInput();
            if (num1 > 45 && num1 < 500 && num1 != 84)
            {
                Console.WriteLine("El número ingresado es válido");
            }
            else
            {
                Console.WriteLine("El valor ingresado no es válido");
            }
        }

        public void Ejercicio8()
        {
            /*Pida un número y si es mayor a 0 y menor a 5, 
             * que nos indique en pantalla que número es con letras(“dos”).
             * Si es igual a 0 que lo muestre en pantalla, y si es menor a 0, 
             * que nos indique si es menor a -20 omayor.*/
            int num1;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = VerifyIntegerInput();
            if (num1 > 0 && num1 < 5)
            {
                switch (num1)
                {
                    case 1:
                        Console.WriteLine("Uno");
                        break;
                    case 2:
                        Console.WriteLine("Dos");
                        break;
                    case 3:
                        Console.WriteLine("Tres");
                        break;
                    case 4:
                        Console.WriteLine("Cuatro");
                        break;
                }
            }else if (num1 == 0)
            {
                Console.WriteLine(num1);
            }else if (num1 < 0)
            {
                if(num1 < -20)
                {
                    Console.WriteLine("Es menor que -20.");
                }
                else
                {
                    Console.WriteLine("Es mayor que -20.");
                }
            }
        }
        private int VerifyIntegerInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Ingrese un numero valido: ");
            }
            return num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();
            ejercicios.Ejercicio8();
            Console.ReadLine();
        }   
    }
}