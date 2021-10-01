using System;
using Parking.App.Dominio;

namespace Parking.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente objCliente1 = new Cliente()
            {
                Id = 7777777,
                Usuario = "usuario007",
                Password = "usuario7777777",
                Nombres = "Homero Jay",
                Apellidos = "Simpson",
                Direccion = "Calle 100 # 11b - 67",
                Telefono = "1234567",

            };
        }

    }
}
