using Examen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Asignatura : Alumno, IAsignatura
{
    public int N1 { get; set; }
    public int N2 { get; set; }
    public int N3 { get; set; }
    public string NombreAsignatura { get; set; }
    public string Horario { get; set; }
    public string NombreDocente { get; set; }

    public double CalcularNotaFinal()
    {
        return N1 + N2 + N3;
    }

    public double CalcularNotaFinal(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }

    public string MensajeNotaFinal(double notaFinal)
    {
        if (notaFinal >= 0 && notaFinal < 60)
        {
            return "Reprobado";
        }
        else if (notaFinal >= 60 && notaFinal < 80)
        {
            return "Bueno";
        }
        else if (notaFinal >= 80 && notaFinal < 90)
        {
            return "Muy Bueno";
        }
        else
        {
            return "Sobresaliente";
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("Datos del alumno:");
        Console.WriteLine($"Nombre: {NombreAlumno}");
        Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
        Console.WriteLine($"Email: {Email}");

        Console.WriteLine("Datos de la asignatura:");
        Console.WriteLine($"Nombre de la asignatura: {NombreAsignatura}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Nombre del docente: {NombreDocente}");

        double notaFinal = CalcularNotaFinal();
        Console.WriteLine($"Nota final: {notaFinal}");
        Console.WriteLine($"Mensaje de la nota final: {MensajeNotaFinal(notaFinal)}");
    }
}