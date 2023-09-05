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
            else
            {
                Console.WriteLine("No puede disparar ya que no adivinó el código");
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
                    default:
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

    public class Clase3
    {
        private int VerifyIntegerInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Ingrese un numero valido: ");
            }
            return num;
        }

        //Pedir un numero del 1 al 7 y decir el dia de la semana correspondiente
        public void Ejercicio1()
        {
            int num1;
            Console.WriteLine("Ingrese un numero del 1 al 7: ");
            num1 = VerifyIntegerInput();
            switch (num1)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }
        }

        //Pedir un numero del 1 al 12 y decir el nombre del mes correspondiente
        public void Ejercicio2() 
        {
            int num1;
            Console.WriteLine("Ingrese un numerodel 1 al 12: ");
            num1 = VerifyIntegerInput();
            switch (num1)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }
        }

        //pedir una letra si es una vocal imprimir dicha letra en pantalla
        public void Ejercicio3()
        {
            string letra;
            Console.WriteLine("Escriba una letra");
            letra = Console.ReadLine();
            letra = letra.ToLower();
            switch (letra)
            {
                case "a":
                    Console.WriteLine(letra);
                    break;
                case "e":
                    Console.WriteLine(letra);
                    break;
                case "i":
                    Console.WriteLine(letra);
                    break;
                case "o":
                    Console.WriteLine(letra);
                    break;
                case "u":
                    Console.WriteLine(letra);
                    break;
                default:
                    Console.WriteLine("Respuesta no valida");
                    break;
            }
        }

        //
        public void Ejercicio4()
        {
            int num1 = 1;
            Console.WriteLine("Ingrese un numero: ");
            num1 = VerifyIntegerInput();
            while (num1 != 0)
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es impar");
                }
                Console.WriteLine("Ingrese un numero: ");
                num1 = VerifyIntegerInput();
            }
            Console.WriteLine("A salido del loop");
        }

        //ingresar 10 numeros y lueego mostrar en pantalla el promedio de los mismos con do while
        public void Ejercicio5()
        {
            int i = 0;
            int num1;
            int suma = 0;
            do
            {
                Console.WriteLine("Ingrese el {0} numero: ",i);
                num1 = VerifyIntegerInput();
                suma += num1;
                i++;
            } while (i < 10);
            suma = suma / 10;
            Console.WriteLine("El promedio es: {0} ", suma);
        }

        //pedir al usuario que ingrese un numero y mostrarlo en pantalla, que termine cuando sea 0
        public void Ejercicio6()
        {
            int num1;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                num1 = VerifyIntegerInput();
                Console.WriteLine("El numero es: {0} ", num1);
            } while (num1 == 0);
        }

        //un programa que lea 10 datos ingresados por el usuario y sume aquellos que sean negativos, mostrarlo en pantalla
        public void Ejercicio7()
        {
            int num1 = 0;
            int resultado = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num1 = VerifyIntegerInput();
                if (num1 < 0)
                {
                    resultado += num1;
                }
            }
            Console.WriteLine("El resultado es: {0}", resultado);
        }

        //un programa que calcule el factorial del numero ingresado ejemplo 5 = 5x4x3x2x1
        public void Ejercicio8()
        {
            int num1;
            int result= 1;
            Console.WriteLine("Ingrese un numero: ");
            num1 = VerifyIntegerInput();
            for (int i = num1; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine("El resultado es: {0}", result);
        }
    }

class Clase4
{

    enum DiceType
    {
        d4,
        d6,
        d8,
        d10,
        d12,
        d20
    }
    public void Ejercicio1()
    {
        DiceType diceType;
        int diceTypeSelection;
        int cantDice;
        int maxValue;
        string diceValue;
        
        Console.WriteLine("Que tipo de dado quiere tirar?");
        Console.WriteLine("1-D4");
        Console.WriteLine("2-D6");
        Console.WriteLine("3-D8");
        Console.WriteLine("4-D10");
        Console.WriteLine("5-D12");
        Console.WriteLine("6-D20");
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Ingrese un numero valido: ");
        }
        diceTypeSelection = int.TryParse(Console.ReadLine(), out num);
        Console.WriteLine("Cuantos dados quiere lanzar?");
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Ingrese un numero valido: ");
        }
        cantDice = int.TryParse(Console.ReadLine(), out num);
    }


}

class Program
{
    
    static void Main(string[] args)
    {   
        
         
    }
}