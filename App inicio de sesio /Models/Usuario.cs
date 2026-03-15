using System;

namespace MyApp.Models  // 👈 AHORA SÍ usa Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}