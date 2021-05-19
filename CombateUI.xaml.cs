using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
    public sealed partial class CombateUI : Page
    {
        string idioma;
        public CombateUI()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs ex) //EN CASO DE QUE PASES PARAMETROS
        {
            //Back.IsEnabled = this.Frame.CanGoBack; //VUELTA ATRAS
            NavigationInfo a = ex.Parameter as NavigationInfo;
            if (a != null) //CARGAR LA IMAGEN DEL PARAMETRO
            {
                idioma = a.language;
                BitmapImage bitimg = a.source as BitmapImage;
                bitimg.UriSource = new Uri(bitimg.UriSource.ToString());
                Perfil.Source = bitimg;
            }
            else
            {

                BitmapImage bitimg = new BitmapImage();
                bitimg.UriSource = new Uri("/Assets/avatar1.png");
                Perfil.Source = bitimg;

            }
        }

        //No se por que no me lo detecta 
        private void Player_Click(object sender, RoutedEventArgs e)
        {

            if (Bar1.Value > 0) Bar1.Value -= 5;
            else Bar1.Value = 80;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            this.Frame.Navigate(typeof(MenuPrincipal), a);
        }



    }
}
