using System;

class Cuenta
{
    public int saldo; // Ahora el saldo no es privado

    // Constructor que valida el saldo inicial
    public Cuenta(int saldoInicial)
    {
        if (saldoInicial >= 0)
        {
            saldo = saldoInicial;
        }
        else
        {
            saldo = 0;
            Console.WriteLine("Error: El saldo inicial era invalido, see establecio el saldo en 0");
        }
    }

    // añadir saldo
    public void Credit(int monto)
    {
        saldo += monto;
        Console.WriteLine($"Se añadio {monto} a la cuenta, saldo actual: {saldo}");
    }

    // retirar saldo de la cuenta
    public void Cargar(int monto)
    {
        if (monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Se retiro {monto} de la cuenta, saldo actual: {saldo}");
        }
        else
        {
            Console.WriteLine("El monto excede el saldo de la cuenta");
        }
    }

    // Función para el saldo actual
    public int ObtenerSaldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main()
    {
        // Crear objetos cuenta
        Cuenta cuenta1 = new Cuenta(100); // Saldo inicial valido
        Cuenta cuenta2 = new Cuenta(-50); // Saldo inicial invalido

        // funciones miembros de la clase
        cuenta1.Credit(50);
        cuenta1.Cargar(30);
        Console.WriteLine("Saldo de cuenta 1: " + cuenta1.ObtenerSaldo());

        cuenta2.Credit(20);
        cuenta2.Cargar(100);
        Console.WriteLine("Saldo de cuenta 2: " + cuenta2.ObtenerSaldo());
        Console.ReadLine();
    }
}

