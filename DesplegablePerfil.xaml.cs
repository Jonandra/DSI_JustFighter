﻿using System;
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
    public sealed partial class DesplegablePerfil : Page
    {
        bool cambiarNombre = false;
        string lastName = "PLAYER 1";
        string newName = "";

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
            Back.IsEnabled = this.Frame.CanGoBack; //VUELTA ATRAS

            if (e != null) //CARGAR LA IMAGEN DEL PARAMETRO
            {
                BitmapImage bitimg = e.Parameter as BitmapImage;
                IMAGEN.Source = bitimg;
            }
        }

        private void EditarImagen_Click(object sender, RoutedEventArgs e)
        {
            cambiarNombre = false;            
            newName = "";
            GuardarCambios();
            this.Frame.Navigate(typeof(SeleccionarImagenPerfil), IMAGEN.Source);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPrincipal));
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
            else { 
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
                if (c>=65 && c <= 90 || c >= 97 && (int)c <= 122 /*|| (int)c >= 48 && (int)c <= 57*/) //65-90 97-122 48-57
                {
                    newName = newName + c;
                    NombrePlayer.Text = newName;
                }
                

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

                }
            }
        }

        
    }
}
