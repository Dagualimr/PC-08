using System.Diagnostics;

class Program
{
    public static string[] alumnos = new string[10];
    public static int[,] notas = new int[10, 10];
    public static int opcion;

    public static void Main(string[] args)
    {
        bool verificacion = true;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Ingrese el nombre del alumno {i + 1}:");
            alumnos[i] = Console.ReadLine()!;
        }
        Console.Clear();

        Console.WriteLine("Ingrese las notas respectivas de cada alumno");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Notas para {alumnos[i]}:");
            for (int j = 0; j < 10; j++)
            {
                while (true)
                {
                    Console.WriteLine($"Ingrese la nota {j + 1} del alumno {alumnos[i]}:");
                    string nota = Console.ReadLine()!;
                    if (int.TryParse(nota, out int notaInt))
                    {
                        if (notaInt >= 0 && notaInt <= 100)
                        {
                            notas[i, j] = notaInt;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nota no válida. Debe estar entre 0 y 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Debe ser un número.");
                    }
                }
            }
            Console.Clear();
        }
        do
        {
            Console.WriteLine("Ingrese el numero de la opcion que quiere realizar:\n1. Mostrar nombre y notas aprobadas para cada alumno. \n2. Mostrar nombre y notas no aprobadas para cada alumno.\n3. Mostrar el promedio de notas del grupo.\n4. Salir del programa.");
            
            opcion = int.Parse(Console.ReadLine()!);

            switch(opcion)
            {
                case 1:
                MostrarNombresYNotasAprobadas();
                break;

                case 2:
                MostrarNombresYNotasNoAprobadas();
                break;

                case 3:
                MostrarPromedioNotasGrupo();
                break;

                case 4:
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
                verificacion = false;
                break;

                default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
            }
        }while(verificacion==true);
    }

    public static void MostrarNombresYNotasAprobadas()
    {
        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Notas aprobadas de {alumnos[i]}:");
            for (int j = 0; j < 10; j++)
            {
                if (notas[i, j] >= 60)
                {
                    Console.WriteLine($"Nota {j + 1}: {notas[i, j]}");
                }
            }
        }
    }

    public static void MostrarNombresYNotasNoAprobadas()
    {
        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Notas no aprobadas de {alumnos[i]}:");
            for (int j = 0; j < 10; j++)
            {
                if (notas[i, j] < 60)
                {
                    Console.WriteLine($"Nota {j + 1}: {notas[i, j]}");
                }
            }
        }
    }

    public static void MostrarPromedioNotasGrupo()
    {
        Console.Clear();
        double sumaTotal = 0;
        int contador = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                sumaTotal += notas[i, j];
                contador++;
            }
        }

        double promedio = sumaTotal / contador;
        Console.WriteLine($"El promedio de notas del grupo es: {promedio}");
    }
}