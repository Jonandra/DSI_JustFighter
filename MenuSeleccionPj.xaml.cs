using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Core;
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
            this.Frame.Navigate(typeof(CombateUI), Perfil.Source); //DesplegablePerfil
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/perfil.jpg");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 80;
            ProgressMovilidad.Value = 40;
            ProgressVida.Value = 60;
            ValueFuerza.Text = "80";
            ValueMovilidad.Text = "40";
            ValueVida.Text = "60";
        }

        private void Mosto_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/mosto.jpg");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 10;
            ProgressMovilidad.Value = 90;
            ProgressVida.Value = 80;
            ValueFuerza.Text = "10";
            ValueMovilidad.Text = "90";
            ValueVida.Text = "80";
        }

        private void Chica_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/chica.jpg");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 30;
            ProgressMovilidad.Value = 100;
            ProgressVida.Value = 50;
            ValueFuerza.Text = "30";
            ValueMovilidad.Text = "100";
            ValueVida.Text = "50";
        }

        private void Avestruz_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/avestruz.png");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 40;
            ProgressMovilidad.Value = 100;
            ProgressVida.Value = 10;
            ValueFuerza.Text = "40";
            ValueMovilidad.Text = "100";
            ValueVida.Text = "10";
        }

        private void Pepe_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/pepe.jpg");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 20;
            ProgressMovilidad.Value = 100;
            ProgressVida.Value = 30;
            ValueFuerza.Text = "20";
            ValueMovilidad.Text = "100";
            ValueVida.Text = "30";
        }

        private void Zeus_Click(object sender, RoutedEventArgs e)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, "/Assets/Zeus.JPG.jpg");
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = 90;
            ProgressMovilidad.Value = 50;
            ProgressVida.Value = 40;
            ValueFuerza.Text = "90";
            ValueMovilidad.Text = "50";
            ValueVida.Text = "40";

        }
    }
}
