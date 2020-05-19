using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace alquilerTopografia_master.Models
{
    public class AlquilerInputModel
    {
        [Required]
        public string TipoId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string NCliente { get; set; }
        [Required(ErrorMessage = "El Telefono es Requerido")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "La Direcciòn es Requerida")]
        public string Direccion { get; set; }
        public string EquipoId { get; set; }
        public string NEquipo { get; set; }
        public string AlquilerId { get; set; }
        public string TiempoAlquiler { get; set; }
    }

    public class AlquilerViewModel : AlquilerInputModel
    {
        public AlquilerViewModel()
        {
        }
        public AlquilerViewModel(Cliente cliente, Alquiler alquiler, Equipo equipo)
        {
            ClienteId = cliente.ClienteId;
            NCliente = cliente.NCliente;
            Telefono = cliente.Telefono;
            Direccion = cliente.Direccion;
            EquipoId = equipo.EquipoId;
            NEquipo = equipo.NEquipo;
            AlquilerId = alquiler.AlquilerId;
            TiempoAlquiler = alquiler.TiempoAlquiler;
            Valor = alquiler.Valor;
        }
        public double Valor { get; set; }
    }
}

