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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_JustFighter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuOnline : Page
    {
        string idioma;
        string name;
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
            if (a.source != null)
            {
                PerfilImagen.Source = a.source;
            }
            if (!string.IsNullOrWhiteSpace(a.language))
            {
                idioma = a.language;
            }
            if (a.name != null)
            {
                name = a.name;
                NOMBRE.Text = name;
            }
        }

        private void Click_Perfil(object sender, RoutedEventArgs e)
        {
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            a.source = PerfilImagen.Source;
            a.name = name;
            this.Frame.Navigate(typeof(DesplegablePerfil), a);
        }
        private void Click_Ajustes(object sender, RoutedEventArgs e)
        {
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            a.name = name;
            this.Frame.Navigate(typeof(Ajustes), a);
        }
        private void Click_Salir(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
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
