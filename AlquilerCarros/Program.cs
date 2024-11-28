using System;
using System.Collections.Generic;
namespace AlquilerDeCarros
{

    public class Carro
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public double PrecioAlquiler { get; set; }

       
        public override string ToString()
        {
            return $"Placa: {Placa}, Marca: {Marca}, Precio de Alquiler: {PrecioAlquiler:C}";
        }
    }

    
    public static class CarroUtil
    {
        
        public static List<Carro> Carros = new List<Carro>();

       
        public static void Crear(string placa, string marca, double precioAlquiler)
        {
            Carros.Add(new Carro { Placa = placa, Marca = marca, PrecioAlquiler = precioAlquiler });
        }

       
        public static void Listar()
        {
            Console.WriteLine("Listado de Carros:");
            foreach (var carro in Carros)
            {
                Console.WriteLine(carro);  
            }
        }

        
        public static void Eliminar(string placa)
        {
            Carros.RemoveAll(c => c.Placa == placa);
        }
    }
}