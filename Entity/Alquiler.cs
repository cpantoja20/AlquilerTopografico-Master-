using Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{

    public class Alquiler
    {
              
        [Key]
        public string AlquilerId { get; set; }

        public string TiempoAlquiler { get; set;}

         public decimal Valor { get; set; }

         public void CalcularAlquiler(string TiempoAlquiler){

         }

         

         public int IdCliente {get; set;}
         public Cliente Cliente {get; set;}

    }
}