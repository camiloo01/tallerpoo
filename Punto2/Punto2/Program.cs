using System;

class Factura
{
    // Atributos publicos
    public string NumeroPieza;
    public string DescripcionPieza;
    public int Cantidad;
    public int PrecioPorArticulo;

    // Constructor
    public Factura(string numeroPieza, string descripcionPieza, int cantidad, int precioPorArticulo)
    {
        NumeroPieza = numeroPieza;
        DescripcionPieza = descripcionPieza;
        Cantidad = cantidad;
        PrecioPorArticulo = precioPorArticulo;
    }

    // Funcion para obtener
    public int ObtenerMontoFactura()
    {
        return Cantidad * PrecioPorArticulo;
    }
}

class Program
{
    static void Main()
    {
        // Crear objeto Factura y probar sus funciones
        Factura factura1 = new Factura("001", "Martillo", 5, 100); // Cantidad y precio valido
        Factura factura2 = new Factura("002", "Clavos", -10, -5);

        Console.WriteLine("Monto de factura 1: $" + factura1.ObtenerMontoFactura());
        Console.WriteLine("Monto de factura 2: $" + factura2.ObtenerMontoFactura());
        Console.ReadLine();
    }
}

