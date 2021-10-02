using System;
namespace Parking.App.Dominio
{
    public class Reserva
    {
        // Asociados UML
        public Auxiliar Auxiliar { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public int Id { get; set; }
        public string EspacioAsignado { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
    }
}