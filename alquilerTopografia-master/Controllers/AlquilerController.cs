using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datos;
using Entity;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace alquilerTopografia_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController: ControllerBase
    {
        private readonly AlquilerService _alquilerService;
        public AlquilerController(AlquilerContext context)
        {
            _alquilerService = new AlquilerService(context);
        }
         // GET: api/Cliente
        [HttpGet]
        public IEnumerable<ClienteViewModel> Gets()
        {
            var alquilers = _alquilerService.ConsultarTodos().Select(p=> new ClienteViewModel(p));
            return alquilers;
        }

        // GET: api/Cliente/5
        [HttpGet("{ClienteId}")]
        public ActionResult<ClienteViewModel> Get(int AlquilerId)
        {
            var alquiler = _alquilerService.BuscarxIdentificacion(AlquilerId);
            if (alquiler == null) return NotFound();
            var alquilerViewModel = new ClienteViewModel();
            return alquilerViewModel;
        }
        
        // POST: api/Cliente
        [HttpPost]
        public ActionResult<ClienteViewModel> Post(ClienteInputModel clienteInput)
        {
            Cliente cliente = MapearProducto(clienteInput);
            var response = _alquilerService.Guardar(alquiler);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Alquiler);
        }
      
        // DELETE: api/Producto/5
        [HttpDelete("{AlquilerId}")]
        public ActionResult<string> Delete(string AlquilerId)
        {
            string mensaje = _alquilerService.Eliminar(AlquilerId);
            return Ok(mensaje);
        }
        private Cliente MapearProducto(ClienteInputModel clienteInput)
        {
            var cliente = new Cliente
            {
                ClienteId = clienteInput.ClienteId,
                NCliente = clienteInput.NCliente,
                Telefono = clienteInput.Telefono,
                Direccion = clienteInput.Direccion,
               
            };
            return cliente;
        }
        // PUT: api/Cliente/5
        [HttpPut("{AlquilerId}")]
        public ActionResult<string> Put(string AlquilerId, Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}