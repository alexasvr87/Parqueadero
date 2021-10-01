
using System.Collections.Generic;
using Parking.App.Dominio;

namespace HospitalEncasa.App.Persistencia
{
    public interface IRepositorioReserva
    {
        public IEnumerable<Reserva> obtenerReserva();
        public void eliminarReserva();
        public Reserva obtenerReservas(int idReservas);
        public Reserva editarReserva(Reserva reserva);
        public Reserva agregarReserva(Reserva reserva);
        
    }
}