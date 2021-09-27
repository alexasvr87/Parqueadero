using System;
using System.Data;

namespace Parking.App.Dominio
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}