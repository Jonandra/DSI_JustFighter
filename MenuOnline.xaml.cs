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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_JustFighter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuOnline : Page
    {
        string idioma;
        public MenuOnline()
        {
            this.InitializeComponent();
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
            }
        }

        private void Click_Perfil(object sender, RoutedEventArgs e)
        {
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            this.Frame.Navigate(typeof(DesplegablePerfil), a);
        }
        private void Click_Ajustes(object sender, RoutedEventArgs e)
        {
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            this.Frame.Navigate(typeof(Ajustes), a);
        }
        private void Click_Salir(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();

        }
    }
}
