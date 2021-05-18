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
using Windows.Globalization;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_JustFighter
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Ajustes : Page
    {
        string idioma;

        public Ajustes()
        {
            this.InitializeComponent();
            ElementSoundPlayer.Volume = 0;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) //EN CASO DE QUE PASES PARAMETROS
        {
            //ApplicationLanguages.PrimaryLanguageOverride = "fr";
            NavigationInfo a = e.Parameter as NavigationInfo;

            if (a != null && !string.IsNullOrWhiteSpace(a.language))
            {
                idioma = a.language;
                if (a.language == "Español")
                {
                    idioma = "Español";
                    Titulo.Text = "Ajustes";
                    vGen.Text = "Volumen General";
                    musica.Text = "Música";
                    graficos.Text = "Gráficos";
                    eSonido.Text = "Efectos de Sonido";
                }
                else if (a.language == "Ingles")
                {
                    idioma = "Ingles";
                    Titulo.Text = "Options";
                    vGen.Text = "General Volume";
                    musica.Text = "Music";
                    graficos.Text = "Graphics";
                    eSonido.Text = "Sound Effects";
                }
                else if (a.language == "Frances")
                {
                    idioma = "Frances";
                    Titulo.Text = "Paramètres";
                    vGen.Text = "Volume général";
                    musica.Text = "Musique";
                    graficos.Text = "Graphique";
                    eSonido.Text = "Effets sonores";
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            this.Frame.Navigate(typeof(MenuPrincipal), a);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Español.IsSelected)
            {
                idioma = "Español";
                Titulo.Text = "Ajustes";
                vGen.Text = "Volumen General";
                musica.Text = "Música";
                graficos.Text = "Gráficos";
                eSonido.Text = "Efectos de Sonido";
            }
            else if (Ingles.IsSelected)
            {
                idioma = "Ingles";
                Titulo.Text = "Options";
                vGen.Text = "General Volume";
                musica.Text = "Music";
                graficos.Text = "Graphics";
                eSonido.Text = "Sound Effects";
            }
            else if (Frances.IsSelected)
            {
                idioma = "Frances";
                Titulo.Text = "Paramètres";
                vGen.Text = "Volume général";
                musica.Text = "Musique";
                graficos.Text = "Graphique";
                eSonido.Text = "Effets sonores";
            }

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

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (e.NewValue == 0) ElementSoundPlayer.Volume = 0;
            else if (e.NewValue == 100) ElementSoundPlayer.Volume = 1;
            else
            {


                if (e.NewValue > e.OldValue) //Subir volumen 
                {

                    ElementSoundPlayer.Volume += 0.01;
                }
                else if (e.NewValue < e.OldValue) //Bajar Volumen 
                {
                    ElementSoundPlayer.Volume -= 0.01;
                }
            }
        }
    }
}
