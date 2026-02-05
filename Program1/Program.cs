using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA BÁSICA ===");

        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Elige una operación:");
        Console.WriteLine("+  Suma");
        Console.WriteLine("-  Resta");
        Console.WriteLine("*  Multiplicación");
        Console.WriteLine("/  División");

        Console.Write("Operación: ");
        string operacion = Console.ReadLine();

        double resultado = 0;
        bool valido = true;

        switch (operacion)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("❌ Error: No se puede dividir entre cero.");
                    valido = false;
                }
                break;
            default:
                Console.WriteLine("❌ Operación no válida.");
                valido = false;
                break;
        }

        if (valido)
            Console.WriteLine($"✅ Resultado: {resultado}");

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
