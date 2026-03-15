using System;
using Xamarin.Forms;
using MyApp.Services;  // 👈 using para Services
using MyApp.Models;     // 👈 using para Models (aunque no se use directamente)

namespace MyApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private UsuarioService _usuarioService;  // Ahora encuentra UsuarioService

        public MainPage()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            lblMensaje.IsVisible = false;
        }
        
        private void ChkPassM_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
        	txtContrasena.IsPassword = !e.Value;
        }

        private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text?.Trim();
            string contrasena = txtContrasena.Text?.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MostrarMensaje("❌ Ingresa usuario y contraseña", true);
                return;
            }

            if (_usuarioService.ValidarUsuario(usuario, contrasena, out var usuarioValido))
            {
                MostrarMensaje("✅ ¡Bienvenido!", false);
                await Navigation.PushAsync(new PaginaBienvenida(usuarioValido));
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
            else
            {
                MostrarMensaje("❌ Usuario o contraseña incorrectos", true);
                
                bool registrar = await DisplayAlert(
                    "Usuario no encontrado",
                    "¿Quieres crear una cuenta nueva?",
                    "Sí, registrarme",
                    "No");
                
                if (registrar)
                {
                    await Navigation.PushAsync(new RegistroPage());
                }
            }
        }

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