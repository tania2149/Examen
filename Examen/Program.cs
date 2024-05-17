using Examen;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Número de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Email: ");
            asignatura.Email = Console.ReadLine();

            Console.WriteLine("Ingrese los datos de la asignatura:");
            Console.Write("Nombre de la asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Horario: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.WriteLine("Ingrese las notas de los tres parciales:");
            Console.Write("Nota del primer parcial (0-30): ");
            asignatura.N1 = int.Parse(Console.ReadLine());

            Console.Write("Nota del segundo parcial (0-30): ");
            asignatura.N2 = int.Parse(Console.ReadLine());

            Console.Write("Nota del tercer parcial (0-40): ");
            asignatura.N3 = int.Parse(Console.ReadLine());

            asignatura.Imprimir();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: La nota ingresada no es un número entero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}