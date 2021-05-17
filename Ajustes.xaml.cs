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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_JustFighter
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Ajustes : Page
    {
        public Ajustes()
        {
            this.InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPrincipal));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Español.IsSelected)
            {
                vGen.Text = "Volumen General";
                musica.Text = "Música";
                graficos.Text = "Gráficos";
                eSonido.Text = "Efectos de Sonido";
            }
            else if (Ingles.IsSelected)
            {
                vGen.Text = "General Volume";
                musica.Text = "Music";
                graficos.Text = "Graphics";
                eSonido.Text = "Sound Effects";
            }
            else if (Frances.IsSelected)
            {
                vGen.Text = "Volume général";
                musica.Text = "Musique";
                graficos.Text = "Graphique";
                eSonido.Text = "Effets sonores";
            }

        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {

            if(e.OriginalKey == VirtualKey.GamepadMenu) this.Frame.Navigate(typeof(MenuPrincipal));
        
        }
    }
}
