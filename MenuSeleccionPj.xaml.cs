using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_JustFighter
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MenuSeleccionPj : Page
    {
        public MenuSeleccionPj()
        {
            this.InitializeComponent();
        }

        //BOTON FIGHT ==> COMBATE UI
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CombateUI)); //DesplegablePerfil
        }

        private void Mosto_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/mosto.jpg");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 30;
            ProgressMovilidad.Value = 100;
            ProgressVida.Value = 80; 
            ValueFuerza.Text = "30";
            ValueMovilidad.Text = "100";
            ValueVida.Text = "80";
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/perfil.jpg");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 70;
            ProgressMovilidad.Value = 90;
            ProgressVida.Value = 30;
            ValueFuerza.Text = "70";
            ValueMovilidad.Text = "90";
            ValueVida.Text = "30";
        }
    }
}
