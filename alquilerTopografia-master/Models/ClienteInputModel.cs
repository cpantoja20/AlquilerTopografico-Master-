using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ClienteInputModel
{
    [Required]
    public int TipoId { get; set; }
    [Required]
    public int IdCliente { get; set; }
    [Required(ErrorMessage = "El Nombre es Requerido")]
    public string NCliente { get; set; }
    [Required(ErrorMessage = "El Telefono es Requerido")]
    public int Telefono { get; set; }
    [Required(ErrorMessage = "La Direcciòn es Requerida")]
    public string Direccion { get; set; }
}
public class ClienteViewModel : ClienteInputModel
{
    public ClienteViewModel()
    {
    }
    public ClienteViewModel(Cliente cliente)
    {
        IdCliente = cliente.IdCliente;
        NCliente = cliente.NCliente;
        Telefono = cliente.Telefono;
        Direccion = cliente.Direccion;

    }
    public decimal Alquiler { get; set; }
}