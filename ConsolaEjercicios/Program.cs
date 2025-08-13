// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EjecutarPositivoNegativoCero();
                    break;
                case "2":
                    EjecutarParOImpar();
                    break;
                case "3":
                    EjecutarMayorDeEdad();
                    break;
                case "4":
                    EjecutarMultiploDe5();
                    break;
                case "5":
                    EjecutarDescuentoPorEdad();
                    break;
                case "6":
                    EjecutarCalificacionAprobatoria();
                    break;
                case "7":
                    EjecutarDiaDeLaSemana();
                    break;
                case "8":
                    EjecutarMayorEntreDos();
                    break;
                case "9":
                    EjecutarMayorEntreTres();
                    break;
                case "10":
                    EjecutarClasificacionAngulos();
                    break;
                case "11":
                    EjecutarCalculoImpuestos();
                    break;
                case "12":
                    EjecutarClasificacionNumeros();
                    break;
                case "13":
                    EjecutarVerificacionAñoBisiesto();
                    break;
                case "14":
                    EjecutarConversionCalificaciones();
                    break;
                case "15":
                    EjecutarComparacionLongitudes();
                    break;
                case "16":
                    EjecutarCalculadoraDescuentos();
                    break;
                case "17":
                    EjecutarTipoTriangulo();
                    break;
                case "18":
                    EjecutarEvaluacionTemperatura();
                    break;
                case "19":
                    EjecutarConversionTurnos();
                    break;
                case "20":
                    EjecutarClasificacionIMC();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción del menú.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Saliendo de la aplicación. ¡Hasta luego!");
    }

    /// <summary>
    /// Muestra el menú de ejercicios en la consola.
    /// </summary>
    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("  Menú de Ejercicios de Programación  ");
        Console.WriteLine("======================================");
        Console.WriteLine("1.  Número positivo, negativo o cero");
        Console.WriteLine("2.  Número par o impar");
        Console.WriteLine("3.  Mayor de edad");
        Console.WriteLine("4.  Múltiplo de 5");
        Console.WriteLine("5.  Descuento por edad");
        Console.WriteLine("6.  Calificación aprobatoria");
        Console.WriteLine("7.  Día de la semana");
        Console.WriteLine("8.  Número mayor entre dos");
        Console.WriteLine("9.  Mayor entre tres números");
        Console.WriteLine("10. Clasificación de ángulos");
        Console.WriteLine("11. Cálculo de impuestos");
        Console.WriteLine("12. Clasificación de números");
        Console.WriteLine("13. Verificación de año bisiesto");
        Console.WriteLine("14. Conversión de calificaciones");
        Console.WriteLine("15. Comparación de tres longitudes");
        Console.WriteLine("16. Calculadora de descuentos");
        Console.WriteLine("17. Tipo de triángulo");
        Console.WriteLine("18. Evaluación de temperatura");
        Console.WriteLine("19. Conversión de horas a turnos");
        Console.WriteLine("20. Clasificación de IMC");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("0. Salir");
        Console.WriteLine("======================================");
        Console.Write("Selecciona una opción: ");
    }


    static void EjecutarParOImpar()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 2: Par o Impar ---");

        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa un número entero: ");

            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El número {numero} es PAR.");
                }
                else
                {
                    Console.WriteLine($"El número {numero} es IMPAR.");
                }

                entradaValida = true; 
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
                Console.WriteLine("Presiona cualquier tecla para reintentar...");
                Console.ReadKey();
                Console.Clear(); 
                Console.WriteLine("--- Ejercicio 2: Par o Impar ---");
            }
        } while (!entradaValida);
    }

    // --- Ejercicio 2: Par o Impar ---
    static void EjecutarPositivoNegativoCero()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 1: Número positivo, negativo o cero ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa un número entero: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numero))
            {
                if (numero > 0)
                    Console.WriteLine($"El número {numero} es POSITIVO.");
                else if (numero < 0)
                    Console.WriteLine($"El número {numero} es NEGATIVO.");
                else
                    Console.WriteLine($"El número {numero} es CERO.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    // --- Ejercicio 3: Mayor de edad ---
    static void EjecutarMayorDeEdad()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 3: Mayor de edad ---");
        Console.Write("Ingresa tu edad: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para verificar si es mayor de 18.
    }

    // --- Ejercicio 4: Múltiplo de 5 ---
    static void EjecutarMultiploDe5()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 4: Múltiplo de 5 ---");
        Console.Write("Ingresa un número: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para verificar si es múltiplo de 5.
    }

    // --- Ejercicio 5: Descuento por edad ---
    static void EjecutarDescuentoPorEdad()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 5: Descuento por edad ---");
        Console.Write("Ingresa la edad del cliente: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para verificar si aplica el descuento (mayor de 60).
    }

    // --- Ejercicio 6: Calificación aprobatoria ---
    static void EjecutarCalificacionAprobatoria()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 6: Calificación aprobatoria ---");
        Console.Write("Ingresa la calificación (0-100): ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para verificar si aprobó (mínimo 60).
    }

    // --- Ejercicio 7: Día de la semana ---
    static void EjecutarDiaDeLaSemana()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 7: Día de la semana ---");
        Console.Write("Ingresa un número del 1 al 7: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para mostrar el día correspondiente.
    }

    // --- Ejercicio 8: Número mayor entre dos ---
    static void EjecutarMayorEntreDos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 8: Número mayor entre dos ---");
        Console.Write("Ingresa el primer número: ");
        string entrada1 = Console.ReadLine();
        Console.Write("Ingresa el segundo número: ");
        string entrada2 = Console.ReadLine();
        // Aquí va tu lógica para determinar cuál es el mayor.
    }

    // --- Ejercicio 9: Mayor entre tres números ---
    static void EjecutarMayorEntreTres()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 9: Mayor entre tres números ---");
        Console.Write("Ingresa el primer número: ");
        string entrada1 = Console.ReadLine();
        Console.Write("Ingresa el segundo número: ");
        string entrada2 = Console.ReadLine();
        Console.Write("Ingresa el tercer número: ");
        string entrada3 = Console.ReadLine();
        // Aquí va tu lógica para encontrar el mayor de los tres.
    }

    // --- Ejercicio 10: Clasificación de ángulos ---
    static void EjecutarClasificacionAngulos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 10: Clasificación de ángulos ---");
        Console.Write("Ingresa el valor de un ángulo en grados: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para clasificar el ángulo.
    }

    // --- Ejercicio 11: Cálculo de impuestos ---
    static void EjecutarCalculoImpuestos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 11: Cálculo de impuestos ---");
        Console.Write("Ingresa tu salario mensual: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para calcular el impuesto correspondiente.
    }

    // --- Ejercicio 12: Clasificación de números ---
    static void EjecutarClasificacionNumeros()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 12: Clasificación de números ---");
        Console.Write("Ingresa el primer número: ");
        string entrada1 = Console.ReadLine();
        Console.Write("Ingresa el segundo número: ");
        string entrada2 = Console.ReadLine();
        Console.Write("Ingresa el tercer número: ");
        string entrada3 = Console.ReadLine();
        // Aquí va tu lógica para determinar si son positivos, negativos, etc.
    }

    // --- Ejercicio 13: Verificación de año bisiesto ---
    static void EjecutarVerificacionAñoBisiesto()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 13: Verificación de año bisiesto ---");
        Console.Write("Ingresa un año: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para verificar si el año es bisiesto.
    }

    // --- Ejercicio 14: Conversión de calificaciones ---
    static void EjecutarConversionCalificaciones()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 14: Conversión de calificaciones ---");
        Console.Write("Ingresa la calificación numérica (0-100): ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para convertir la calificación a letra.
    }

    // --- Ejercicio 15: Comparación de tres longitudes ---
    static void EjecutarComparacionLongitudes()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 15: Comparación de tres longitudes ---");
        Console.Write("Ingresa la primera longitud: ");
        string entrada1 = Console.ReadLine();
        Console.Write("Ingresa la segunda longitud: ");
        string entrada2 = Console.ReadLine();
        Console.Write("Ingresa la tercera longitud: ");
        string entrada3 = Console.ReadLine();
        // Aquí va tu lógica para determinar si pueden formar un triángulo.
    }

    // --- Ejercicio 16: Calculadora de descuentos ---
    static void EjecutarCalculadoraDescuentos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 16: Calculadora de descuentos ---");
        Console.Write("Ingresa el precio del producto: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para aplicar el descuento según el monto.
    }

    // --- Ejercicio 17: Tipo de triángulo ---
    static void EjecutarTipoTriangulo()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 17: Tipo de triángulo ---");
        Console.Write("Ingresa la longitud del primer lado: ");
        string entrada1 = Console.ReadLine();
        Console.Write("Ingresa la longitud del segundo lado: ");
        string entrada2 = Console.ReadLine();
        Console.Write("Ingresa la longitud del tercer lado: ");
        string entrada3 = Console.ReadLine();
        // Aquí va tu lógica para determinar si es equilátero, isósceles o escaleno.
    }

    // --- Ejercicio 18: Evaluación de temperatura ---
    static void EjecutarEvaluacionTemperatura()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 18: Evaluación de temperatura ---");
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para imprimir el mensaje según la temperatura.
    }

    // --- Ejercicio 19: Conversión de horas a turnos ---
    static void EjecutarConversionTurnos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 19: Conversión de horas a turnos ---");
        Console.Write("Ingresa la hora (0-23): ");
        string entrada = Console.ReadLine();
        // Aquí va tu lógica para determinar el turno (mañana, tarde, etc.).
    }

    // --- Ejercicio 20: Clasificación de IMC ---
    static void EjecutarClasificacionIMC()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 20: Clasificación de IMC ---");
        Console.Write("Ingresa tu peso en kg: ");
        string entradaPeso = Console.ReadLine();
        Console.Write("Ingresa tu altura en metros (ej: 1.75): ");
        string entradaAltura = Console.ReadLine();
        // Aquí va tu lógica para calcular el IMC y clasificarlo.
    }

private static void MostrarMensajeError()
{
    Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido.");
    Console.WriteLine("Presiona cualquier tecla para reintentar...");
    Console.ReadKey();
    Console.Clear();
}
}