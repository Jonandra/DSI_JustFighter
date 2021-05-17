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
    public sealed partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            this.InitializeComponent();

        }

        private void Click_Jugar(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuSeleccionPj));
        }

        private void Click_Tienda(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tienda));
        }

        private void Click_Online(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuOnline));
        }
        private void Click_Perfil(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DesplegablePerfil));
        }
        private void Click_Ajustes(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ajustes));
        }
        private void Click_Salir(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
