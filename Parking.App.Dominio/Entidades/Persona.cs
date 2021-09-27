using System;
namespace Parking.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        private string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}