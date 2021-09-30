using System;
namespace Parking.App.Dominio
{
    public class Parqueadero
    {
        public Vehiculo VehiculoP{ get; set;}

        public string TotalEspacios { get; set; }
        public string EspaciosDisponibles { get; set; }
        public string EspaciosOcupados { get; set; }
    }
}