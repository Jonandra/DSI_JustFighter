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
using Windows.Globalization;
using Windows.System;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_JustFighter
{

    class NavigationInfo
    {
        public ImageSource source;
        public string language;
        public string name;
    }
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class SeleccionarImagenPerfil : Page
    {

        string idioma;
        string name;
        public SeleccionarImagenPerfil()
        {
            this.InitializeComponent();
        }

        private void cambiarPersonaje(string imagen)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(ImagenSeleccionada.BaseUri, imagen);
            ImagenSeleccionada.Source = im;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) //EN CASO DE QUE PASES PARAMETROS
        {
            //ApplicationLanguages.PrimaryLanguageOverride = "fr";
            NavigationInfo a = e.Parameter as NavigationInfo;

            if (a == null)
            {
                a = new NavigationInfo();
                a.language = "Español";
            }
            if (!string.IsNullOrWhiteSpace(a.language))
            {
                idioma = a.language;
                if (a.language == "Español") Titulo.Text = "Imagen de Perfil";
                if (a.language == "Ingles") Titulo.Text = "Profile Image";
                if (a.language == "Frances") Titulo.Text = "Image de Profil";
            }

            if (a.source != null) //CARGAR LA IMAGEN DEL PARAMETRO
            {
                BitmapImage bitimg = a.source as BitmapImage;
                ImagenSeleccionada.Source = bitimg;
            }
            if (a.name != null)
            {
                name = a.name;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            a.source = ImagenSeleccionada.Source;
            a.name = name;
            this.Frame.Navigate(typeof(DesplegablePerfil), a); //DesplegablePerfil
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/perfil.jpg");
        }

        private void Mosto_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/mosto.jpg");
        }

        private void Chica_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/chica.jpg");
        }

        private void Avestruz_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/avestruz.png");
        }

        private void Pepe_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/pepe.jpg");
        }

        private void Zeus_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/Zeus.jpg");
        }

        private void Monke_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/monke.jpg");
        }

        private void Ortega_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/ortega.jpg");
        }

        private void Boi_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/boi.jpg");
        }

        private void Sealion_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/silaion.png");
        }

        private void Calico_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/calico.jpg");
        }
        private void Scorp_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/avatarLuchador.jpg");
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            DependencyObject candidate = null;
            switch (e.OriginalKey)
            {
                case VirtualKey.Right:
                case VirtualKey.GamepadDPadRight:
                    // el candidato es el primer objeto al navegar hacia abajo en la lista 
                    candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Right);
                    // movemos el foco al siguiente objeto
                    if (candidate == null)
                        candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Left);

                    (candidate as Control).Focus(FocusState.Keyboard);
                    e.Handled = true;
                    break;
                case VirtualKey.Left:
                case VirtualKey.GamepadDPadLeft:
                    // el candidato es el primer objeto al navegar hacia abajo en la lista 
                    candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Left);
                    // movemos el foco al siguiente objeto
                    if (candidate == null)
                        candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Right);

                    (candidate as Control).Focus(FocusState.Keyboard);
                    e.Handled = true;
                    break;
                case VirtualKey.Up:
                case VirtualKey.GamepadDPadUp:
                    // el candidato es el primer objeto al navegar hacia abajo en la lista 
                    candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Up);
                    // movemos el foco al siguiente objeto
                    if (candidate == null)
                        candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Down);

                    (candidate as Control).Focus(FocusState.Keyboard);
                    e.Handled = true;
                    break;
                case VirtualKey.GamepadMenu:
                    NavigationInfo a = new NavigationInfo();
                    a.language = idioma;
                    a.name = name;
                    this.Frame.Navigate(typeof(MenuPrincipal), a);
                    break;
                case VirtualKey.Down:
                case VirtualKey.GamepadDPadDown:
                    // el candidato es el primer objeto al navegar hacia abajo en la lista
                    candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Down);
                    // movemos el foco al siguiente objeto
                    if (candidate == null)
                        candidate = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Up);

                    //Casteamos el Objeto que guarda el cambio de foco a un control para establecer eso como foco en focusmanager
                    (candidate as Control).Focus(FocusState.Keyboard);
                    e.Handled = true;
                    break;
                    //Si`por ejemplo quiero hacerlo para quedesde jugar vaya a salir igualo la variable Candidate al boton en cuestion 



            }
        }
    }
}
