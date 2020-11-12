using System;
using System.Collections.Generic;

namespace SalasDeReunion.Models
{
    public partial class Salas
    {
        public int SalaId { get; set; }
        public int NumeroDeSala { get; set; }
        public int Capacidad { get; set; }
        public bool Proyector { get; set; }
        public bool Pizarra { get; set; }
        public bool AccesoInet { get; set; }
    }
}
