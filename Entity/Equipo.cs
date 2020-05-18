using System;
using System.ComponentModel.DataAnnotations;

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
    }
}