using System;
namespace Parking.App.Dominio
{
    public class Parqueadero
    {
        [Key]
        public int Id { get; set; }
        public int TotalEspaciosCarros { get; set; }
        public int TotalEspaciosMotos { get; set; }
    }
}