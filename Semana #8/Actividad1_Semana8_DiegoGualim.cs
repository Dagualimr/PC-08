using System.Globalization;
using System.Runtime.InteropServices;
using System.Timers;

class Actividad1_Semama8_DiegoGualim
{
    public static void Main()
    {
        int valor;
        string numero;
        bool esNumero;
        do
        {
        Console.WriteLine("Ingrese un numero entero");
        numero=Console.ReadLine() ??"";
        esNumero= int.TryParse(numero, out valor);
        }while (!esNumero);
        int factorial = CalcularFactorial(valor);
        Console.WriteLine("El factorial de "+numero+" es "+factorial);
    }
    public static int CalcularFactorial(int numero)
    {
        if (numero==0)
        {
            return 1;
        }
        else
        {
            int factorial=1;

            for (int i=1; i<=numero; i++)
            {
                factorial *=i;
            }
            return factorial;
        }
    }
}