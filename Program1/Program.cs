using System;

class Calculadora
{
    static void Main()
    {
        bool continuar = true;

        Console.WriteLine("=== CALCULADORA BÁSICA MEJORADA ===");

        while (continuar)
        {
            double num1, num2;

            // Validar primer número
            Console.Write("Ingresa el primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("❌ Número inválido. Intenta de nuevo: ");
            }

            // Validar segundo número
            Console.Write("Ingresa el segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("❌ Número inválido. Intenta de nuevo: ");
            }

            Console.WriteLine("\nElige una operación:");
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
                        Console.WriteLine("❌ No se puede dividir entre cero.");
                        valido = false;
                    }
                    break;
                default:
                    Console.WriteLine("❌ Operación no válida.");
                    valido = false;
                    break;
            }

            if (valido)
                Console.WriteLine($"\n✅ Resultado: {resultado}");

            Console.Write("\n¿Deseas hacer otra operación? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s")
                continuar = false;

            Console.WriteLine();
        }

        Console.WriteLine("Gracias por usar la calculadora 😄");
    }
}
