using System;

public class Cliente
{
    // Propiedades de la clase Cliente
    public int Dni { get; set; }
    public string Nombre { get; set; }
    public double PagoMaximo { get; set; }

    // Constructor
    public Cliente(int dni, string nombre, double pagoMaximo)
    {
        Dni = dni;
        Nombre = nombre;
        PagoMaximo = pagoMaximo;
    }

    // Método ToString() que devuelve una representación de Cliente
    public override string ToString()
    {
        return $"DNI: {Dni}, Nombre: {Nombre}, Pago Máximo: {PagoMaximo:C}";
    }
}
