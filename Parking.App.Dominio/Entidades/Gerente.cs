using System;
namespace Parking.App.Dominio
{
    public class Gerente:Persona
    {
        public Reserva Reserva { get; set; }
    }
}