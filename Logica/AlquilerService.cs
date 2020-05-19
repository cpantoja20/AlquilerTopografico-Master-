using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class AlquilerService
    {
        private readonly AlquilerContext _context;
        public AlquilerService(AlquilerContext context)
        {
           _context = context;
        }

        public GuardarAlquilerResponse Guardar(Alquiler alquiler)
        {
            try
            {
                var AlquilerAux = _context.Alquilers.Find(alquiler.AlquilerId);
                if (AlquilerAux != null)
                {
                    return new GuardarAlquilerResponse($"Error de la Aplicacion: El Alquiler ya se encuentra registrado!");
                }        
                _context.Alquilers.Add(alquiler);
                _context.SaveChanges();
                return new GuardarAlquilerResponse(alquiler);
            }
            catch (Exception e)
            {
                return new GuardarAlquilerResponse($"Error de la Aplicacion: {e.Message}");
            }
        }
    public List<Alquiler> ConsultarTodos()
        {
            
            List<Alquiler> alquilers = _context.Alquilers.ToList();
            return alquilers;
        }
        public string Eliminar(string AlquilerId)
        {
            try
            {
                
                var alquiler = _context.Alquilers.Find(AlquilerId);
                if (alquiler != null)
                {
                    _context.Alquilers.Remove(alquiler);
                    return ($"El registro {alquiler.AlquilerId} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {AlquilerId} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }

        }
        public Alquiler BuscarxIdentificacion(int AlquilerId)
        {
            
            Alquiler alquiler = _context.Alquilers.Find(AlquilerId);
            return alquiler;
        }
    }

    public class GuardarAlquilerResponse 
    {
        public GuardarAlquilerResponse(Alquiler alquiler)
        {
            Error = false;
            Alquiler = alquiler;
        }
        public GuardarAlquilerResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Alquiler Alquiler { get; set; }
    }
}