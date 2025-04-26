using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Estudiante
{
    private string? _nombre, _carrera, _carnet;
    private int _edad = 0;
    private double _notaAdmision=0;

    public string? Nombre
    {
        get => _nombre ?? "NA";
        set => _nombre = value;
    } 

     public string? Carrera
    {
        get => _carrera ?? "NA";
        set => _carrera = value;
    } 

     public string? Carnet
    {
        get => _carnet ?? "NA";
        set => _carnet = value;
    } 

     public int Edad
    {
        get => _edad;
        set => _edad = value;
    } 

     public double NotaAdmision
    {
        get => _notaAdmision;
        set => _notaAdmision = value;
    } 
}

class Program
{
    public static void Main()
    {

        string nombre, carrera, carnet, entrada;
        int edad =0;
        double nota=0;
        bool proceso;

        Estudiante estudiante = new Estudiante();
        
        do
        {
            proceso=true;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine()!;
            Console.WriteLine("Ingrese la carrera a la que pertenece");
            carrera = Console.ReadLine()!;
            Console.WriteLine("Ingrese su edad");
            entrada = Console.ReadLine()!;
            Console.WriteLine("Ingrese su nummero de carnet");
            carnet = Console.ReadLine()!;
            Console.WriteLine("Ingrese su nota");
            entrada = Console.ReadLine()!;

            if(!int.TryParse(entrada,out edad))
            {
                Console.WriteLine("La edad ingresada debe de ser un valor entero");
                proceso=false;
            }

            if (!double.TryParse(entrada, out nota))
            {
                Console.WriteLine("La entrada no es un número válido. Por favor intente nuevamente.");
                proceso = false;
            }

            if(nota<0 || nota>100)
            {
                Console.WriteLine("El valor de la nota ingrasada debe estar entre 0 a 100");
                proceso=false;
            }

            if(!carnet.EndsWith("2025"))
            {
                Console.WriteLine("El carnet ingresado no es valido");
                proceso=false;
            }
        }while(proceso==false);

        Console.WriteLine("Los valores ingresados son");
        MostrarResumen(ref nombre, ref carrera, ref carnet, ref edad, ref nota);
        NotaAdmision(ref nota);

        nombre=estudiante.Nombre ?? string.Empty;
        carrera=estudiante.Carrera ?? string.Empty;
        carnet=estudiante.Carnet ?? string.Empty;
        edad=estudiante.Edad;
        nota=estudiante.NotaAdmision;
    }

    public static void MostrarResumen(ref string a, ref string b, ref string c, ref int d, ref double e)
    {
        Console.WriteLine($"Nombre = {a}\nEdad = {d}\nCarrera = {b}\nCarnet= {c}\nNota={e}");
    }

    public static void NotaAdmision(ref double a)
    {
        if(a<75)
        {
            Console.WriteLine("Lo sentimos, pero su nota no es la necesaria para poder matricularse.");
        }
        else
        {
            Console.WriteLine("Feliciddes, usted ya puede matricularse para el siguiente ciclo.");
        }
    }
}