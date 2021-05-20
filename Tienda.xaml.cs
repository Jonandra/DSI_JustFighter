using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Background;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DSI_JustFighter
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>

    public sealed partial class Tienda : Page
    {
        string idioma;
        string name;
        bool rightPressed = false;
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
            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            a.name = name;
            this.Frame.Navigate(typeof(MenuPrincipal), a);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) //EN CASO DE QUE PASES PARAMETROS
        {
            NavigationInfo a = e.Parameter as NavigationInfo;

            if (a == null)
            {
                a = new NavigationInfo();
                a.language = "Español";
            }
            if (!string.IsNullOrWhiteSpace(a.language))
            {
                idioma = a.language;
                if (a.language == "Español")
                {
                    Titulo.Text = "Tienda";
                    BotonCajas.Content = "Cajas";
                    BotonPersonajes.Content = "Personajes";
                    BotonSkins.Content = "Skins";
                    TextCajaPequeña.Text = "Caja Pequeña - 0.99$";
                    TextCajaMediana.Text = "Caja Mediana - 3.99$";
                    TextCajaGrande.Text = "Caja Grande - 10.99$";
                }
                if (a.language == "Ingles")
                {
                    Titulo.Text = "Shop";
                    BotonCajas.Content = "Boxes";
                    BotonPersonajes.Content = "Characters";
                    BotonSkins.Content = "Skins";
                    TextCajaPequeña.Text = "Small Box - 0.99$";
                    TextCajaMediana.Text = "Medium Box - 3.99$";
                    TextCajaGrande.Text = "Big box - 10.99$";
                }
                if (a.language == "Frances")
                {
                    Titulo.Text = "Boutique";
                    BotonCajas.Content = "Des boites";
                    BotonPersonajes.Content = "Personnages";
                    BotonSkins.Content = "Skins";
                    TextCajaPequeña.Text = "Petite boîte - 0.99$";
                    TextCajaMediana.Text = "Boîte moyenne - 3.99$";
                    TextCajaGrande.Text = "Grosse boite - 10.99$";
                }
            }
            if (a.name != null)
            {
                name = a.name;
            }
        }

        //Flecha Derecha 
        private void RightButtonClick(object sender, RoutedEventArgs e)
        {
            if (CanvasBox2.Visibility == Visibility.Visible) //Si estan los personajes visibles 
            {
                D1Personajes.Text = "OtakoidMan";
                BitmapImage logo = new BitmapImage();
                logo.UriSource = new Uri(E1Personajes.BaseUri, "/Assets/ortega.jpg");
                E1Personajes.Source = logo;


                D2Personajes.Text = "Locked until level 15";
                BitmapImage logo2 = new BitmapImage();
                logo2.UriSource = new Uri(E2Personajes.BaseUri, "/Assets/lockLogo.png");
                E2Personajes.Source = logo2;

                if (!rightPressed)
                {
                    D3Personajes.FontSize = D3Personajes.FontSize - 2;

                }

                D3Personajes.Text = "BUY TO UNLOCK RANDOM SKIN";
                BitmapImage logo3 = new BitmapImage();
                logo3.UriSource = new Uri(E3Personajes.BaseUri, "/Assets/lockLogo.png");
                E3Personajes.Source = logo3;

                rightPressed = true;  //Si pulsamos el boton derecho donde se va a manipular la fuente

            }
            else if (CanvasBox3.Visibility == Visibility.Visible) //Si estan las skins visibles 
            {
                //CAMBIAR
                D1Skin.Text = "HammerPeng- 7.25$";
                BitmapImage logo = new BitmapImage();
                logo.UriSource = new Uri(E1Skin.BaseUri, "/Assets/HammerPeng.png");
                E1Skin.Source = logo;

                D2Skin.Text = "LOCKED!";
                BitmapImage logo2 = new BitmapImage();
                logo2.UriSource = new Uri(E2Skin.BaseUri, "/Assets/lockLogo.png");
                E2Skin.Source = logo2;

                //CAMBIAR
                D3Skin.Text = "BluePoison - 30$";
                BitmapImage logo3 = new BitmapImage();
                logo3.UriSource = new Uri(E3Skin.BaseUri, "/Assets/BluePoison.png");
                E3Skin.Source = logo3;
            }
        }
        //Flecha Izquierda 
        private void LeftButtonClick(object sender, RoutedEventArgs e) //Volvemos a establecer los valores 
        {
            //C D E -> personajes y skins
            if (CanvasBox2.Visibility == Visibility.Visible) //Si estan los personajes visibles 
            {
                D1Personajes.Text = "BrickBreaker - 7$";
                BitmapImage logo = new BitmapImage();
                logo.UriSource = new Uri(E1Personajes.BaseUri, "/Assets/pepe.jpg");
                E1Personajes.Source = logo;

                D2Personajes.Text = "WhiteWidow - 15.2$";
                BitmapImage logo2 = new BitmapImage();
                logo2.UriSource = new Uri(E2Personajes.BaseUri, "/Assets/chica.jpg");
                E2Personajes.Source = logo2;


                if (rightPressed)
                {
                    D3Personajes.FontSize = D3Personajes.FontSize + 2;

                }
                D3Personajes.Text = "SoMangoKush - 39$";
                BitmapImage logo3 = new BitmapImage();
                logo3.UriSource = new Uri(E3Personajes.BaseUri, "/Assets/avatar1.png");
                E3Personajes.Source = logo3;
                rightPressed = false;
            }
            else if (CanvasBox3.Visibility == Visibility.Visible) //Si estan las skins visibles 
            {

                D1Skin.Text = "Street Skin - 7.25$";
                BitmapImage logo = new BitmapImage();
                logo.UriSource = new Uri(E1Skin.BaseUri, "/Assets/personaje1.png");
                E1Skin.Source = logo;

                D2Skin.Text = "Elegant Skin - 23.50$";
                BitmapImage logo2 = new BitmapImage();
                logo2.UriSource = new Uri(E2Skin.BaseUri, "/Assets/personaje2.png");
                E2Skin.Source = logo2;

                D3Skin.Text = "Magic Skin - 30$";
                BitmapImage logo3 = new BitmapImage();
                logo3.UriSource = new Uri(E3Skin.BaseUri, "/Assets/Mortal Skin.png");
                E3Skin.Source = logo3;



            }
        }

        //Botones para cambiar la visibilidad de los distintos viewBoxes
        //Activaremos o desactivaremos viewboxes para que se vean distinta info
        //Usar el viewbox de las cajas para los personajes y skins
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CanvasBox.Visibility = Visibility.Visible;
            CanvasBox2.Visibility = Visibility.Collapsed;
            CanvasBox3.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CanvasBox2.Visibility = Visibility.Visible;
            CanvasBox.Visibility = Visibility.Collapsed;
            CanvasBox3.Visibility = Visibility.Visible;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CanvasBox3.Visibility = Visibility.Visible;
            CanvasBox2.Visibility = Visibility.Collapsed;
            CanvasBox.Visibility = Visibility.Collapsed;
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
