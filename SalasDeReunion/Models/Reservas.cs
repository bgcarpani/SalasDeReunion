using System;
using System.Collections.Generic;

namespace SalasDeReunion.Models
{
    public partial class Reservas
    {
        public int ReservasId { get; set; }
        public int SalaId { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string NombreReserva { get; set; }
        public int CantidadDeGente { get; set; }
        public bool Proyector { get; set; }
        public bool Pizarra { get; set; }
        public bool AccesoInet { get; set; }

        public string EstadoReservacion { get; set; }

    }
}
