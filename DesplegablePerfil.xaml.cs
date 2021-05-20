using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class DesplegablePerfil : Page
    {
        bool cambiarNombre = false;
        string newName = "";
        string idioma;
        public string lastName = "PLAYER 1";

        public DesplegablePerfil()
        {
            this.InitializeComponent();

            //PAGINA HACIA ATRAS
            KeyboardAccelerator GoBack = new KeyboardAccelerator();
            GoBack.Key = VirtualKey.GoBack;
            GoBack.Invoked += BackInvoked;
            KeyboardAccelerator AltLeft = new KeyboardAccelerator();
            AltLeft.Key = VirtualKey.Left;
            AltLeft.Invoked += BackInvoked;
            this.KeyboardAccelerators.Add(GoBack);
            this.KeyboardAccelerators.Add(AltLeft);
            // ALT routes here
            AltLeft.Modifiers = VirtualKeyModifiers.Menu;
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
                if (a.language == "Español")
                {
                    Titulo.Text = "Perfil";
                    EditarImagen.Content = "Editar Perfil";
                    CambiarNombre.Content = "Cambiar Nombre";
                    TextLogrosDesbloqueados.Text = "Logros Desbloqueados:";
                    TextLogrosDesbloqueados2.Text = "Logros Desbloqueados:";
                    TextPartidasGanadas.Text = "Partidas Ganadas:";
                    TextMisionCompleta.Text = "Misión Completada";
                    TextMisionCorrespondiente.Text = "Misión Correspondiente";
                    TextMisionCorrespondiente2.Text = "Misión Correspondiente";
                    TextMisionCorrespondiente3.Text = "Misión Correspondiente";
                    TextDesadiosPendientes.Text = "Desafíos Pendientes";
                }
                if (a.language == "Ingles")
                {
                    Titulo.Text = "Profile";
                    EditarImagen.Content = "Edit Profile";
                    CambiarNombre.Content = "Rename";
                    TextLogrosDesbloqueados.Text = "Achievements Unlocked:";
                    TextLogrosDesbloqueados2.Text = "Achievements Unlocked:";
                    TextPartidasGanadas.Text = "Total Wins:";
                    TextMisionCompleta.Text = "Mission Complete";
                    TextMisionCorrespondiente.Text = "Corresponding Mission";
                    TextMisionCorrespondiente2.Text = "Corresponding Mission";
                    TextMisionCorrespondiente3.Text = "Corresponding Mission";
                    TextDesadiosPendientes.Text = "Challenges Pending";
                }
                if (a.language == "Frances")
                {
                    Titulo.Text = "Profil";
                    EditarImagen.Content = "Editer le profil";
                    CambiarNombre.Content = "Rebaptiser";
                    TextLogrosDesbloqueados.Text = "Succès débloqués:";
                    TextLogrosDesbloqueados2.Text = "Succès débloqués:";
                    TextPartidasGanadas.Text = "Jeux gagnés:";
                    TextMisionCompleta.Text = "Mission complète";
                    TextMisionCorrespondiente.Text = "Mission correspondante";
                    TextMisionCorrespondiente2.Text = "Mission correspondante";
                    TextMisionCorrespondiente3.Text = "Mission correspondante";
                    TextDesadiosPendientes.Text = "Défis en attente";
                }
            }
            if (a.name != null)
            {
                lastName = a.name;
                NombrePlayer.Text = lastName;
            }
            if (a.source != null) //CARGAR LA IMAGEN DEL PARAMETRO
            {
                BitmapImage bitimg = a.source as BitmapImage;
                IMAGEN.Source = bitimg;
            }
        }

        private void EditarImagen_Click(object sender, RoutedEventArgs e)
        {
            cambiarNombre = false;
            newName = "";
            GuardarCambios();

            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            a.source = IMAGEN.Source;
            a.name = lastName;
            this.Frame.Navigate(typeof(SeleccionarImagenPerfil), a);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //MediaElement PlayMusic = new MediaElement(); 
            //StorageFolder Folder = Windows.ApplicationModel.Package.Current.InstalledLocation; 
            //Folder = await Folder.GetFolderAsync("MyFolder"); 
            //StorageFile sf = await Folder.GetFileAsync("MyFile.mp3"); 
            //PlayMusic.SetSource(await sf.OpenAsync(FileAccessMode.Read), sf.ContentType); PlayMusic.Play();

            NavigationInfo a = new NavigationInfo();
            a.language = idioma;
            a.source = IMAGEN.Source;
            a.name = lastName;
            this.Frame.Navigate(typeof(MenuPrincipal), a);
            //On_BackRequested();
        }

        // Handles system-level BackRequested events and page-level back  button Click events
        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();//IMAGEN.Source IMAGEN.Source
                return true;
            }
            return false;
        }

        private void BackInvoked(KeyboardAccelerator sender,
        KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        } //VULTRA ATRAS------------------------------------------------------------------------------------



        private void Nombre_Click(object sender, RoutedEventArgs e)
        {
            if (!cambiarNombre)
            {
                cambiarNombre = true;
                NombrePlayer.Text = newName;
                CambiarNombre.Content = "Guardar Cambios";
            }

            //GUARDAR CAMBIOS
            else
            {
                cambiarNombre = false;
                GuardarCambios();
                //CambiarNombre.Background = "Wheat"; //CAMBIAR COLOR

            }
        }

        private void GuardarCambios()
        {
            if (newName == "") NombrePlayer.Text = lastName;
            else
            {
                NombrePlayer.Text = newName;
                lastName = newName;
            }
            CambiarNombre.Content = "Cambiar Nombre";
            newName = "";
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (cambiarNombre)
            {
                char c = (char)e.Key;
                //CONTROL PARA QUE SOLO VALGAN LETRAS, NUMEROS ETC
                if (c >= 65 && c <= 90 || c >= 97 && (int)c <= 122 /*|| (int)c >= 48 && (int)c <= 57*/) //65-90 97-122 48-57
                {
                    newName = newName + c;
                    NombrePlayer.Text = newName;
                }
            }
                DependencyObject candidate = null;
                switch (e.Key)
                {
                    case VirtualKey.Escape:
                        newName = "";
                        NombrePlayer.Text = "";
                        GuardarCambios();
                        break;
                    case VirtualKey.Enter:
                        GuardarCambios();
                        break;
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
                        a.name = lastName;
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
