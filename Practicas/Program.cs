namespace Practicas;
/*
   Total de la cuenta:     $1,200.25
   Propina (15%):          $180
   Total a pagar:          $1,380
   Personas:               4
   Costo por persona:      $345
 */
class Program
{
    static void Main(string[] args)
    {
        // float (coma flotante) - decimales con presiciòn baja
        // double - decimales con presiciòn media
        // decimal - decimales con presicion alta
        // total de la cuenta - float
        // propina entero
        // total a pagar - float
        
        
        // lenguajes no tipados, permiten la asignacion de variables sin importar su tipo, c# es un lenguaje tipado por lo que
        // una vez definida la variables no es posible asignarle un tipo distinto
        // var miVariable = "hola"
        // miVariable = 34

        /*
            Pasos. 
            1. Solicitar al usuario el monto total de la cuenta
            2. Leer la cuenta
            3. Solicitar el porcentaje de propina
            4. Leer el porcentaje de propina
            5. Solicitar el numero de personas
            6. Leer el numero de personas
            7. Calcular
            8. Mostrar resultado
        */
        float Cuenta = 0;
        float Propina = 0;
        int Personas = 0;

        while (Cuenta <= 0)
        {
            Console.Write("Ingresa el monto total de la cuenta: ");
            Cuenta = float.Parse(Console.ReadLine());

            if (Cuenta <= 0)
            {
                Console.WriteLine("La cuenta debe ser mayor que 0.");
            }
        }

        while (Propina < 0)
        {
            Console.Write("Ingresa el porcentaje de propina: ");
            Propina = float.Parse(Console.ReadLine());

            if (Propina < 0)
            {
                Console.WriteLine("La propina no puede ser negativa.");
            }
        }

        while (Personas <= 0)
        {
            Console.Write("Ingresa el número de personas: ");
            Personas = int.Parse(Console.ReadLine());

            if (Personas <= 0)
            {
                Console.WriteLine("El número de personas debe ser mayor que 0.");
            }
        }

        float ValorPropina = Cuenta * Propina / 100;
        float Total = Cuenta + ValorPropina;
        float PorPersona = Total / Personas;

        Console.WriteLine();
        Console.WriteLine("Cuenta: " + Cuenta);
        Console.WriteLine("Propina (" + Propina + "%): " + ValorPropina);
        Console.WriteLine("Total: " + Total);
        Console.WriteLine("Personas: " + Personas);
        Console.WriteLine("Total por persona: " + PorPersona);
    }
}
/*
   Total de la cuenta:     $1,200.25
   Propina (xx%):          $180
   Total a pagar:          $1,380
   Personas:               4
   Costo por persona:      $345
 */
 
 /*
    Tarea modificar el programa
    1. Salida como se muestra en el comentario
    2. Propina deberá de mostrarse como en el ejemplo Promina (la propina seleccionada%): El valor
    3. Que pasa si pongo 0 como propina?
        a. Probar el programa escribiendo propina 0 y ver resultados
        b. Corregir
    4. Que pasa si pongo 0 en las personas?
        a. Probar el programa
        b. Corregir si es necesario
    5. Que pasa si la cuenta es 0?
        a. Probar
        b. Corregir 
    Regla: No interrumpir el programa si se ingresa un dato invàlido (a excepcion de letras en las entradas) se debe volver a pedir.
    Opcional: Crear funciones. 
 */