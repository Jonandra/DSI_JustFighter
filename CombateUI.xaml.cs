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
        public CombateUI()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) //EN CASO DE QUE PASES PARAMETROS
        {
            //Back.IsEnabled = this.Frame.CanGoBack; //VUELTA ATRAS

                if (e != null) //CARGAR LA IMAGEN DEL PARAMETRO
                {
                    BitmapImage bitimg = e.Parameter as BitmapImage;
                    Perfil.Source = bitimg;
                }
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key==VirtualKey.B || e.OriginalKey==VirtualKey.GamepadB)
            {
                if (Bar2.Value > 0) Bar2.Value -= 5;
                else Bar2.Value = 60;
            }
        }
    }
}
