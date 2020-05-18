using System;
using System.Security;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entity
{

    public class Equipo
    {
        [Key]
        public string IdEquipo { get; set; }
        public string NEquipo { get; set; }
        public int Marca { get; set; }
        public string Tiempo { get; set; }
        public decimal Valor { get; set; }

        public List<Alquiler> Alquilers { get; } = new List<Alquiler>();
    }
}