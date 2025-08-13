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
       
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa tu edad: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numero))
            {
                if (numero > 17)
                    Console.WriteLine($"Eres mayor de edad.");
                else if (numero < 18)
                    Console.WriteLine($"Eres menor de edad.");
               

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    // --- Ejercicio 4: Múltiplo de 5 ---
    static void EjecutarMultiploDe5()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 4: Múltiplo de 5 ---");
       
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa un número: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numero))
            {
                if (numero % 5== 0)
                    Console.WriteLine($"El número {numero} es múltiplo de 5.");
                else if (numero < 18)
                    Console.WriteLine($"El número {numero} NO es múltiplo de 5.");


                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }
    // --- Ejercicio 5: Descuento por edad ---
    static void EjecutarDescuentoPorEdad()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 5: Descuento por edad ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa la edad del cliente: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int edad))
            {
                if (edad >= 60)
                    Console.WriteLine("¡Felicidades! Tienes un descuento del 50%.");
                else
                    Console.WriteLine("No aplicas para el descuento por edad.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarCalificacionAprobatoria()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 6: Calificación aprobatoria ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa la calificación del estudiante (0-100): ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int calificacion) && calificacion >= 0 && calificacion <= 100)
            {
                if (calificacion >= 60)
                    Console.WriteLine("¡Aprobado!");
                else
                    Console.WriteLine("Reprobado.");

                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa una calificación entre 0 y 100.");
                Console.WriteLine("Presiona cualquier tecla para reintentar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("--- Ejercicio 6: Calificación aprobatoria ---");
            }
        } while (!entradaValida);
    }

    static void EjecutarDiaDeLaSemana()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 7: Día de la semana ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa un número del 1 al 7: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int dia) && dia >= 1 && dia <= 7)
            {
                string diaSemana = "";
                switch (dia)
                {
                    case 1: diaSemana = "Lunes"; break;
                    case 2: diaSemana = "Martes"; break;
                    case 3: diaSemana = "Miércoles"; break;
                    case 4: diaSemana = "Jueves"; break;
                    case 5: diaSemana = "Viernes"; break;
                    case 6: diaSemana = "Sábado"; break;
                    case 7: diaSemana = "Domingo"; break;
                }
                Console.WriteLine($"El día de la semana es: {diaSemana}");

                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número entre 1 y 7.");
                Console.WriteLine("Presiona cualquier tecla para reintentar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("--- Ejercicio 7: Día de la semana ---");
            }
        } while (!entradaValida);
    }

    static void EjecutarMayorEntreDos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 8: Número mayor entre dos ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa el primer número: ");
            string entrada1 = Console.ReadLine();
            Console.Write("Ingresa el segundo número: ");
            string entrada2 = Console.ReadLine();

            if (int.TryParse(entrada1, out int num1) && int.TryParse(entrada2, out int num2))
            {
                if (num1 > num2)
                    Console.WriteLine($"El número mayor es: {num1}");
                else if (num2 > num1)
                    Console.WriteLine($"El número mayor es: {num2}");
                else
                    Console.WriteLine("Ambos números son iguales.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarMayorEntreTres()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 9: Mayor entre tres números ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa el primer número: ");
            string entrada1 = Console.ReadLine();
            Console.Write("Ingresa el segundo número: ");
            string entrada2 = Console.ReadLine();
            Console.Write("Ingresa el tercer número: ");
            string entrada3 = Console.ReadLine();

            if (int.TryParse(entrada1, out int num1) && int.TryParse(entrada2, out int num2) && int.TryParse(entrada3, out int num3))
            {
                int mayor = Math.Max(num1, Math.Max(num2, num3));
                Console.WriteLine($"El número mayor es: {mayor}");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarClasificacionAngulos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 10: Clasificación de ángulos ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa el valor de un ángulo en grados: ");
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out double angulo))
            {
                if (angulo > 0 && angulo < 90)
                    Console.WriteLine("El ángulo es AGUDO.");
                else if (angulo == 90)
                    Console.WriteLine("El ángulo es RECTO.");
                else if (angulo > 90 && angulo < 180)
                    Console.WriteLine("El ángulo es OBTUSO.");
                else if (angulo == 180)
                    Console.WriteLine("El ángulo es LLANO.");
                else
                    Console.WriteLine("Ángulo fuera de los rangos de clasificación.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarCalculoImpuestos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 11: Cálculo de impuestos ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa tu salario mensual: ");
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out double salario))
            {
                double impuesto = 0;
                if (salario < 10000)
                    impuesto = 0;
                else if (salario >= 10000 && salario <= 30000)
                    impuesto = salario * 0.10;
                else
                    impuesto = salario * 0.20;

                Console.WriteLine($"Tu impuesto a pagar es: {impuesto:C}");
                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarClasificacionNumeros()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 12: Clasificación de números ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa el primer número: ");
            string entrada1 = Console.ReadLine();
            Console.Write("Ingresa el segundo número: ");
            string entrada2 = Console.ReadLine();
            Console.Write("Ingresa el tercer número: ");
            string entrada3 = Console.ReadLine();

            if (int.TryParse(entrada1, out int num1) && int.TryParse(entrada2, out int num2) && int.TryParse(entrada3, out int num3))
            {
                if (num1 > 0 && num2 > 0 && num3 > 0)
                    Console.WriteLine("Todos los números son positivos.");
                else if (num1 < 0 && num2 < 0 && num3 < 0)
                    Console.WriteLine("Todos los números son negativos.");
                else if (num1 == 0 || num2 == 0 || num3 == 0)
                    Console.WriteLine("Hay ceros.");
                else
                    Console.WriteLine("Los números son mixtos (positivos y negativos).");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarVerificacionAñoBisiesto()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 13: Verificación de año bisiesto ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa un año: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int año))
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                    Console.WriteLine($"El año {año} es un AÑO BISIESTO.");
                else
                    Console.WriteLine($"El año {año} NO es un año bisiesto.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarConversionCalificaciones()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 14: Conversión de calificaciones ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa la calificación numérica (0-100): ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int calificacion) && calificacion >= 0 && calificacion <= 100)
            {
                string letra;
                if (calificacion >= 90)
                    letra = "A";
                else if (calificacion >= 80)
                    letra = "B";
                else if (calificacion >= 70)
                    letra = "C";
                else if (calificacion >= 60)
                    letra = "D";
                else
                    letra = "F";

                Console.WriteLine($"La calificación en letra es: {letra}");
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa una calificación entre 0 y 100.");
                Console.WriteLine("Presiona cualquier tecla para reintentar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("--- Ejercicio 14: Conversión de calificaciones ---");
            }
        } while (!entradaValida);
    }

    static void EjecutarComparacionLongitudes()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 15: Comparación de tres longitudes ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa la primera longitud: ");
            string entrada1 = Console.ReadLine();
            Console.Write("Ingresa la segunda longitud: ");
            string entrada2 = Console.ReadLine();
            Console.Write("Ingresa la tercera longitud: ");
            string entrada3 = Console.ReadLine();

            if (double.TryParse(entrada1, out double lado1) && double.TryParse(entrada2, out double lado2) && double.TryParse(entrada3, out double lado3))
            {
                if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                    Console.WriteLine("Las longitudes SÍ pueden formar un triángulo.");
                else
                    Console.WriteLine("Las longitudes NO pueden formar un triángulo.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarCalculadoraDescuentos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 16: Calculadora de descuentos ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa el precio del producto: ");
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out double precio))
            {
                double descuento = 0;
                if (precio >= 50 && precio <= 100)
                    descuento = precio * 0.05;
                else if (precio > 100)
                    descuento = precio * 0.10;

                Console.WriteLine($"El descuento aplicado es de: {descuento:C}");
                Console.WriteLine($"El precio final es: {precio - descuento:C}");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarTipoTriangulo()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 17: Tipo de triángulo ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa la longitud del primer lado: ");
            string entrada1 = Console.ReadLine();
            Console.Write("Ingresa la longitud del segundo lado: ");
            string entrada2 = Console.ReadLine();
            Console.Write("Ingresa la longitud del tercer lado: ");
            string entrada3 = Console.ReadLine();

            if (double.TryParse(entrada1, out double lado1) && double.TryParse(entrada2, out double lado2) && double.TryParse(entrada3, out double lado3))
            {
                if (lado1 == lado2 && lado2 == lado3)
                    Console.WriteLine("Es un triángulo EQUILÁTERO.");
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    Console.WriteLine("Es un triángulo ISÓSCELES.");
                else
                    Console.WriteLine("Es un triángulo ESCALENO.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarEvaluacionTemperatura()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 18: Evaluación de temperatura ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa la temperatura en grados Celsius: ");
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out double temperatura))
            {
                if (temperatura < 0)
                    Console.WriteLine("Hace mucho frío.");
                else if (temperatura >= 0 && temperatura <= 20)
                    Console.WriteLine("Clima fresco.");
                else if (temperatura >= 21 && temperatura <= 30)
                    Console.WriteLine("Clima agradable.");
                else
                    Console.WriteLine("Hace mucho calor.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    static void EjecutarConversionTurnos()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 19: Conversión de horas a turnos ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa la hora (0-23): ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int hora) && hora >= 0 && hora <= 23)
            {
                if (hora >= 6 && hora <= 11)
                    Console.WriteLine("Turno: Mañana.");
                else if (hora >= 12 && hora <= 17)
                    Console.WriteLine("Turno: Tarde.");
                else if (hora >= 18 && hora <= 23)
                    Console.WriteLine("Turno: Noche.");
                else
                    Console.WriteLine("Turno: Madrugada.");

                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa una hora entre 0 y 23.");
                Console.WriteLine("Presiona cualquier tecla para reintentar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("--- Ejercicio 19: Conversión de horas a turnos ---");
            }
        } while (!entradaValida);
    }

    static void EjecutarClasificacionIMC()
    {
        Console.Clear();
        Console.WriteLine("--- Ejercicio 20: Clasificación de IMC ---");
        bool entradaValida = false;
        do
        {
            Console.Write("Ingresa tu peso en kg: ");
            string entradaPeso = Console.ReadLine();
            Console.Write("Ingresa tu altura en metros (ej: 1.75): ");
            string entradaAltura = Console.ReadLine();

            if (double.TryParse(entradaPeso, out double peso) && double.TryParse(entradaAltura, out double altura) && altura > 0)
            {
                double imc = peso / (altura * altura);
                Console.WriteLine($"Tu IMC es: {imc:F2}");

                if (imc < 18.5)
                    Console.WriteLine("Clasificación: Bajo peso.");
                else if (imc >= 18.5 && imc <= 24.9)
                    Console.WriteLine("Clasificación: Normal.");
                else if (imc >= 25 && imc <= 29.9)
                    Console.WriteLine("Clasificación: Sobrepeso.");
                else
                    Console.WriteLine("Clasificación: Obesidad.");

                entradaValida = true;
            }
            else
            {
                MostrarMensajeError();
            }
        } while (!entradaValida);
    }

    private static void MostrarMensajeError()
{
    Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido.");
    Console.WriteLine("Presiona cualquier tecla para reintentar...");
    Console.ReadKey();
    Console.Clear();
}
}