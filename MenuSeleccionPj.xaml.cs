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
using Windows.System;
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

            //PAGINA HACIA ATRAS
            KeyboardAccelerator GoBack = new KeyboardAccelerator();
            GoBack.Key = VirtualKey.GoBack;
            GoBack.Invoked += BackInvoked;
            KeyboardAccelerator AltLeft = new KeyboardAccelerator();
            AltLeft.Key = VirtualKey.Left;
            AltLeft.Invoked += BackInvoked;
            this.KeyboardAccelerators.Add(GoBack);
            this.KeyboardAccelerators.Add(AltLeft);
            // ALT routes here
            AltLeft.Modifiers = VirtualKeyModifiers.Menu;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e) //EN CASO DE QUE PASES PARAMETROS
        {
            Back.IsEnabled = this.Frame.CanGoBack; //VUELTA ATRAS

            //if (e != null) //CARGAR LA IMAGEN DEL PARAMETRO
            //{
            //    BitmapImage bitimg = e.Parameter as BitmapImage;
            //    Imagen.Source = bitimg;
            //}
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
        }

        // Handles system-level BackRequested events and page-level back  button Click events
        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
                return true;
            }
            return false;
        }

        private void BackInvoked(KeyboardAccelerator sender,
        KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        } //VULTRA ATRAS------------------------------------------------------------------------------------


        //BOTON FIGHT ==> COMBATE UI
        private void Fight_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CombateUI), Perfil.Source); //DesplegablePerfil
        }

        private void cambiarPersonaje(int fuerza, int movil, int vida, string imagen)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(Perfil.BaseUri, imagen);
            Perfil.Source = im;
            //CAMBIAR INFO
            ProgressFuerza.Value = fuerza;
            ProgressMovilidad.Value = movil;
            ProgressVida.Value = vida;
            ValueFuerza.Text = fuerza.ToString();
            ValueMovilidad.Text = movil.ToString();
            ValueVida.Text = vida.ToString();
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(80, 40, 60, "/Assets/perfil.jpg");
        }

        private void Mosto_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(10, 90, 80, "/Assets/mosto.jpg");
        }

        private void Chica_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(30, 100, 50, "/Assets/chica.jpg");
        }

        private void Avestruz_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(40, 100, 10, "/Assets/avestruz.png");
        }

        private void Pepe_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(20, 100, 30, "/Assets/pepe.jpg");
        }

        private void Zeus_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(90, 50, 40, "/Assets/Zeus.jpg");
        }

        private void Monke_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(40, 90, 50, "/Assets/monke.jpg");
        }

        private void Ortega_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(10, 10, 40, "/Assets/ortega.jpg");
        }

        private void Boi_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(20, 50, 90, "/Assets/boi.jpg");
        }

        private void Sealion_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(50, 50, 60, "/Assets/silaion.png");
        }

        private void Calico_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(20, 80, 40, "/Assets/calico.jpg");
        }

        private void Scorp_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje(50, 90, 35, "/Assets/avatarLuchador.jpg");
        }
    }
}
