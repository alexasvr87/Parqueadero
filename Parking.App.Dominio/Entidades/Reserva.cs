using System;
namespace Parking.App.Dominio
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public string EspacioAsignado { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
    }
}