using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Cliente
    {
        public string TipoId { get; set; }
        [Key]
        public int IdCliente { get; set; }
        public string NCliente { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public float Alquiler { get; set; }

    }
}