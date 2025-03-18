class Program
{
    public static void Main(string[] args)
    {
        double a,b;
        
        Console.WriteLine("Este programa hara que si el a es mayor que b sea verdadero, de otro modo sera falso.");
       Console.WriteLine("Ingresa el primer valor a");
       a=double.Parse(Console.ReadLine());

       Console.WriteLine("Ingrese el segundo valor b");
       b=double.Parse(Console.ReadLine());

       if (a>b)
       {
        Console.WriteLine("Verdadero");
       }
       else if (a<b)
       {
        Console.WriteLine("Falso");
       }
       else
       {
        Console.WriteLine("Igualdad");
       }
    }
}
