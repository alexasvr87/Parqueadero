using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend.pages
{
    public class ListaReservaModel : PageModel
    {
        private readonly IRepositorioReserva RepositorioReserva;
        public IEnumerable<Reserva> Reservas;
        public ListaReservaModel(IRepositorioReserva RepositorioReserva)
        {
            this.RepositorioReserva = RepositorioReserva;
        }
            
        public void OnGet()
        {
            Reservas=RepositorioReserva.Reservas;
        }
    }
}
