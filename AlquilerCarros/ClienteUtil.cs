using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlquilerCarros
{
    public class ClienteUtil
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public static void Crear(int dni, string nombre, double pagoMaximo)
        {
            Cliente cliente = new Cliente(dni, nombre, pagoMaximo);
            clientes.Add(cliente);
            Console.WriteLine("Cliente agregado exitosamente.");
        }
        public static void Listar()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
                return;
            }

            Console.WriteLine("Clientes registrados:");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }
        public static void Eliminar(int dni)
        {
            Cliente clienteAEliminar = clientes.Find(c => c.Dni == dni);
            if (clienteAEliminar != null)
            {
                clientes.Remove(clienteAEliminar);
                Console.WriteLine("Cliente eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un cliente con ese DNI.");
            }
        }
    }
}
