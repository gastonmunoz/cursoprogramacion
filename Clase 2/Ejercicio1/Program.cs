//Ejercicio 1
//Una agenda personal permita registrar reuniones en las que el usuario va a participar.
//En tal agenda debe registrarse donde ocurrirá la reunión, quienes van a participar de
//ella, el tema que van a tratar y la duración de la misma.

using Ejercicio1;

internal class Program
{
    private static void Main(string[] args)
    {
        MostrarMenu();
        //Console.WriteLine("Ingresar numero para calcular factorial:");
        //string numero = Console.ReadLine();
        //if (int.TryParse(numero, out int numeroConvertido))
        //{
        //    int factorial = CalcularFactorial(numeroConvertido);
        //    Console.WriteLine($"Resultado {factorial}");
        //}
    }

    // Recursividad
    // Una función se llama así misma, hasta que se cumpla una condición de corte.
    // 1x2x3x4x5x.....
    // 10: 10 x Factorial(9) = 4x3x2x1 -----
    // ...
    // 5: 5 x Factorial(4) = 4x3x2x1 -----
    // 4: 4 x Factorial(3) = 3x2x1 ----
    // 3: 3 x Factorial(2) = 2x1  --- 
    // 2: 2 x Factorial(1) = 1x1 --
    // 1: 1 -
    private static int CalcularFactorial(int numeroConvertido)
    {
        if (numeroConvertido == 1)
        {
            return 1;
        }
        else
        {
            int factorialDelAnterior = CalcularFactorial(numeroConvertido - 1);
            return numeroConvertido * factorialDelAnterior;
        }
    }

    private static void MostrarMenu()
    {
        string palabra;
        List<Reunion> reuniones = new List<Reunion>();
        do
        {
            Console.WriteLine("MENU, elegir opcion:");
            Console.WriteLine("1. Cargar reunión");
            Console.WriteLine("2. Ver reuniones");
            palabra = Console.ReadLine();
            Console.Clear();

            switch (palabra)
            {
                case "1":
                    Reunion reunionNueva = CargarReunion();
                    reuniones.Add(reunionNueva);
                    break;
                case "2":
                    MostrarReuniones(reuniones);
                    break;
            }

            Console.WriteLine("Escriba 'salir' para terminar.");
            palabra = Console.ReadLine();
            Console.Clear();
        } while (palabra != "salir");
    }

    private static void MostrarReuniones(List<Reunion> reuniones)
    {
        foreach (Reunion reunion in reuniones)
        {
            Console.WriteLine("Lugar: " + reunion.Lugar);
            Console.WriteLine("Tema: " + reunion.Tema);
            Console.WriteLine("Duración en horas: " + reunion.DuracionHoras);
            Console.WriteLine("Participantes: ");

            foreach (Participante participante in reunion.Participantes)
            {
                Console.WriteLine(participante.Id + " - " + participante.Nombre);
            }
        }
    }

    private static Reunion CargarReunion()
    {
        string palabra = "";
        Reunion reunion;
        do
        {
            string lugar = CargarLugar();
            Console.Clear();
            List<Participante> participantes = CargarParticipantes();
            Console.Clear();
            string tema = CargarTema();
            Console.Clear();
            float duracion = CargarDuracion();
            Console.Clear();

            reunion = new Reunion();
            reunion.Lugar = lugar;
            reunion.Participantes = participantes;
            reunion.Tema = tema;
            reunion.DuracionHoras = duracion;

            Console.WriteLine("Escriba 'salir' para terminar.");
            palabra = Console.ReadLine();
        } while (palabra != "salir");
        Console.Clear();
        return reunion;
    }

    private static float CargarDuracion()
    {
        Console.WriteLine("Ingresar duración de la reunión, en horas (decimal):");
        string horas = Console.ReadLine();
        return float.Parse(horas);
    }

    private static string CargarTema()
    {
        Console.WriteLine("Tema de la reunión:");
        return Console.ReadLine();
    }

    private static string CargarLugar()
    {
        Console.WriteLine("Lugar de la reunión:");
        return Console.ReadLine();
    }

    public static List<Participante> CargarParticipantes()
    {
        string nombre;
        int contador = 1;
        List<Participante> resultado = new List<Participante>();
        do
        {
            //pido datos
            Console.WriteLine("Ingresar participantes, poner 'salir' para terminar:");
            nombre = Console.ReadLine();

            if (nombre != "salir")
            {
                //Creo el objeto Participante y lo asigno.
                Participante participante = new Participante();
                participante.Id = contador;
                participante.Nombre = nombre;

                //Lo agrego al listado de participantes.
                resultado.Add(participante);
                contador++;
            }
        } while (nombre != "salir");
        return resultado;
    }
}