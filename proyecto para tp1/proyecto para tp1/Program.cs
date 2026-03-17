using System;

class Program
{
    static void Main()
    {
        string mensaje = Saludar("Laura");
        Console.WriteLine(mensaje);
    }

    static string Saludar(string nombre)
    {
        return "Hola " + nombre;
    }
}