using System;
using Parking.App.Dominio;

namespace Parking.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo objVehiculo1 = new Vehiculo()
            {
                Placa = "JNV78",
                Marca = "AKT",
                Modelo = "Jet5",
                Color = "Negro",
                TipoVehiculo = Moto,
            };

            Cliente objCliente1 = new Cliente()
            {
                Usuario = "usuario007",
                Password = "usuario7777777",
                Nombres = "Homero Jay",
                Apellidos = "Simpson",
                Direccion = "Calle 100 # 11b - 67",
                Telefono = "1234567",
                FechaNacimiento = "19/04/1987",
                Vehiculo = objVehiculo1
            };


        }
    }
}
