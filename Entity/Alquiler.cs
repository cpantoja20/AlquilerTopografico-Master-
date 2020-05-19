using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{

    public class Alquiler
    {

        [Key]
        public string AlquilerId { get; set; }

        public DateTime FInicial { get; set; }

        public DateTime FFinal { get; set; }

        public double Valor { get; set; }

        public List<Alquiler> Alquilers { get; } = new List<Alquiler>();

    }
}