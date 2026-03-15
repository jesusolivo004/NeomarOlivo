using System;
using Xamarin.Forms;
using MyApp.Services;
using MyApp.Models;

namespace MyApp.Pages
{
    public partial class ListaUsuariosPage : ContentPage
    {
        private UsuarioService _usuarioService;

        public ListaUsuariosPage()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            
            // Cargar todos los usuarios en la lista
            listaUsuarios.ItemsSource = _usuarioService.ObtenerTodos();
        }

        private async void listaUsuarios_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Usuario usuario)
            {
                // Mostrar toda la información en un solo mensaje
                string mensaje = $"👤 USUARIO: {usuario.NombreUsuario}\n" +
                                $"🔑 CONTRASEÑA: {usuario.Contrasena}\n" +
                                $"👑 ROL: {usuario.Rol}\n" +
                                $"📅 REGISTRO: {usuario.FechaRegistro:dd/MM/yyyy HH:mm}";
                
                await DisplayAlert("INFORMACIÓN COMPLETA", mensaje, "OK");
                
                // Quitar selección de la lista
                listaUsuarios.SelectedItem = null;
            }
        }
    }
}