using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using MyApp.Models;

namespace MyApp.Services
{
    public class UsuarioService
    {
        private readonly string _rutaArchivo;
        private List<Usuario> _usuarios;

        public UsuarioService()
        {
            try
            {
                string carpetaBase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                _rutaArchivo = Path.Combine(carpetaBase, "usuarios.json");
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"❌ Error: {ex.Message}");
                _usuarios = new List<Usuario>();
                _usuarios.Add(CrearUsuarioAdmin());
            }
        }

        private Usuario CrearUsuarioAdmin()
        {
            return new Usuario
            {
                NombreUsuario = "NStudio_2010",
                Contrasena = "jesusolivo004",
                Rol = "Admin",
                FechaRegistro = DateTime.Now
            };
        }

        private void CargarUsuarios()
        {
            try
            {
                if (File.Exists(_rutaArchivo))
                {
                    string json = File.ReadAllText(_rutaArchivo);
                    _usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
                }
                else
                {
                    _usuarios = new List<Usuario>();
                    _usuarios.Add(CrearUsuarioAdmin());
                    GuardarUsuarios();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"❌ Error cargando: {ex.Message}");
                _usuarios = new List<Usuario>();
                _usuarios.Add(CrearUsuarioAdmin());
            }
        }

        private void GuardarUsuarios()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_usuarios, Formatting.Indented);
                File.WriteAllText(_rutaArchivo, json);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"❌ Error guardando: {ex.Message}");
            }
        }

        public bool ValidarUsuario(string usuario, string contrasena, out Usuario usuarioEncontrado)
        {
            usuarioEncontrado = _usuarios.FirstOrDefault(u => 
                u.NombreUsuario == usuario && u.Contrasena == contrasena);
            
            return usuarioEncontrado != null;
        }

        public bool UsuarioExiste(string usuario)
        {
            return _usuarios.Any(u => u.NombreUsuario == usuario);
        }

        public bool RegistrarUsuario(string usuario, string contrasena)
        {
            if (UsuarioExiste(usuario))
                return false;

            _usuarios.Add(new Usuario
            {
                NombreUsuario = usuario,
                Contrasena = contrasena,
                Rol = "Usuario",
                FechaRegistro = DateTime.Now
            });

            GuardarUsuarios();
            return true;
        }

        // NUEVO MÉTODO AGREGADO
        public List<Usuario> ObtenerTodos()
        {
            return _usuarios;
        }
    }
}