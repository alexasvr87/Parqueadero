using System.Collections.Generic;
using HospitalEncasa.App.Persistencia;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public class RepositorioReserva : IRepositorioReserva
    {
        private readonly AppContext _appContext;

        public RepositorioReserva(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Reserva agregarReserva(Reserva reserva)
        {
            throw new System.NotImplementedException();
        }

        public Reserva editarReserva(Reserva reserva)
        {
            throw new System.NotImplementedException();
        }

        public void eliminarReserva()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Reserva> obtenerReserva()
        {
            throw new System.NotImplementedException();
        }

        public Reserva obtenerReservas(int idReservas)
        {
            throw new System.NotImplementedException();
        }
    }
}