using AlquilerCarros;

public class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Crear Cliente");
            Console.WriteLine("2. Listar Clientes");
            Console.WriteLine("3. Eliminar Cliente");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Crear Cliente
                    CrearCliente();
                    break;
                case 2:
                    // Listar Clientes
                    ClienteUtil.Listar();
                    break;
                case 3:
                    // Eliminar Cliente
                    EliminarCliente();
                    break;
                case 4:
                    // Salir
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                    break;
            }

            if (opcion != 4)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 4);
    }

    static void CrearCliente()
    {
        Console.Write("Ingrese el DNI del cliente: ");
        int dni = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el pago máximo del cliente: ");
        double pagoMaximo = Convert.ToDouble(Console.ReadLine());

        ClienteUtil.Crear(dni, nombre, pagoMaximo);
    }

    static void EliminarCliente()
    {
        Console.Write("Ingrese el DNI del cliente a eliminar: ");
        int dni = Convert.ToInt32(Console.ReadLine());

        ClienteUtil.Eliminar(dni);
    }
    }