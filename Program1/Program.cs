using System;

class MayorDeEdad
{
    static void Main()
    {
        int edad;

        Console.Write("Ingresa tu edad: ");

        // Validar que sea un número entero
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.Write("❌ Edad inválida. Ingresa una edad válida: ");
        }

        if (edad >= 18)
        {
            Console.WriteLine("✅ Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("🚫 Eres menor de edad.");
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
