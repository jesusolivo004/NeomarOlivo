using System;
using Xamarin.Forms;
using MyApp.Models;

namespace MyApp.Pages
{
    public partial class PaginaBienvenida : ContentPage
    {
        private Usuario _usuario;

        public PaginaBienvenida(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            
            if (usuario.Rol == "Admin")
            {
                lblBienvenida.Text = $"¡Bienvenido ADMIN\n{usuario.NombreUsuario}!";
                btnVerUsuarios.IsVisible = true;
            }
            else
            {
                lblBienvenida.Text = $"¡Bienvenido\n{usuario.NombreUsuario}!";
                btnVerUsuarios.IsVisible = false;
            }
        }

        private async void btnCerrarSesion_Clicked(object sender, EventArgs e)
        {
            bool respuesta = await DisplayAlert(
                "Cerrar Sesión", 
                $"¿Hasta luego {_usuario.NombreUsuario}?",
                "Sí", 
                "No");
            
            if (respuesta)
            {
                await Navigation.PopToRootAsync();
            }
        }
        
        // NUEVO MÉTODO PARA EL BOTÓN DE VER USUARIOS
        private async void btnVerUsuarios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaUsuariosPage());
        }
        
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}