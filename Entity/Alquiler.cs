using Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{

    public class Alquiler
    {
        public string IdEquipo { get; set; }

        public string IdCliente { get; set; }
       
        public decimal Valor { get; set; }
        
        [Key]
        public string IdAlquiler { get; set; }

    }
}