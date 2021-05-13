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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DSI_JustFighter
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Tienda : Page
    {
        public Tienda()
        {
            this.InitializeComponent();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Vbox.Width = e.NewSize.Width;
            Vbox.Height = e.NewSize.Height;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuSeleccionPj));
        }
        

        //Flecha Derecha 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        //Flecha Izquierda 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        //Botones para cambiar la visibilidad de los distintos viewBoxes
        //Activaremos o desactivaremos viewboxes para que se vean distinta info
        //Usar el viewbox de las cajas para los personajes y skins
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CanvasBox.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CanvasBox.Visibility = Visibility.Visible;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CanvasBox.Visibility = Visibility.Collapsed;
        }
    }
}
