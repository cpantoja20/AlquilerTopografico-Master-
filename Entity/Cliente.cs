using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Cliente
    {
        public string TipoId { get; set; }
        [Key]
        public int ClienteId { get; set; }
        public string NCliente { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int AlquilerId { get; set; }

    }
}