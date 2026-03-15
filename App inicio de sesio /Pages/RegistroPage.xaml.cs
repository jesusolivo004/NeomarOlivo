using System;
using Xamarin.Forms;
using MyApp.Services;

namespace MyApp.Pages
{
    public partial class RegistroPage : ContentPage
    {
        private UsuarioService _usuarioService;

        public RegistroPage()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        // Evento para mostrar/ocultar contraseñas
        private void chkMostrarPass_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            txtNuevaContrasena.IsPassword = !e.Value;
            txtConfirmarContrasena.IsPassword = !e.Value;
        }

        // Evento del botón Registrarse
        private async void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
            string usuario = txtNuevoUsuario.Text?.Trim();
            string contrasena = txtNuevaContrasena.Text?.Trim();
            string confirmacion = txtConfirmarContrasena.Text?.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(confirmacion))
            {
                MostrarMensaje("❌ Completa todos los campos", true);
                return;
            }

            // Validar longitud mínima de contraseña
            if (contrasena.Length < 4)
            {
                MostrarMensaje("❌ La contraseña debe tener al menos 4 caracteres", true);
                return;
            }

            // Validar que las contraseñas coincidan
            if (contrasena != confirmacion)
            {
                MostrarMensaje("❌ Las contraseñas no coinciden", true);
                return;
            }

            // Intentar registrar al usuario
            bool registrado = _usuarioService.RegistrarUsuario(usuario, contrasena);

            if (registrado)
            {
                MostrarMensaje("✅ ¡Registro exitoso! Serás redirigido...", false);
                
                // Esperar 2 segundos y volver al login
                await System.Threading.Tasks.Task.Delay(2000);
                await Navigation.PopAsync();
            }
            else
            {
                MostrarMensaje("❌ El usuario ya existe. Elige otro nombre", true);
            }
        }

        // Evento para volver al login
        private async void btnVolver_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        // Método para mostrar mensajes
        private void MostrarMensaje(string mensaje, bool esError)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.TextColor = esError ? Color.Red : Color.Green;
            lblMensaje.IsVisible = true;
            
            if (esError)
            {
                Device.StartTimer(TimeSpan.FromSeconds(3), () =>
                {
                    lblMensaje.IsVisible = false;
                    return false;
                });
            }
        }
    }
}