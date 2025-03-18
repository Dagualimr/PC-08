
class Clase_Semana9
{
     static void Main()
    {
        bool VF = true;
        do
        {
            Console.WriteLine("Ingrese un número de no mas de 6 digitos");
            if (int.TryParse(Console.ReadLine(), out int num)|| num < 1 || num > 999999)
            {
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} no es número primo");
                    }
                    else
                    {
                        Console.WriteLine($"{num} es un número primo");
                    }
                }
            }
            else
            {
                    Console.WriteLine("No es válido");
                VF = false;
            }
        }
        while(VF==true);
    }
}
