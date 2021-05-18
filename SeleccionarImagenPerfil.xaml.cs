﻿using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_JustFighter
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class SeleccionarImagenPerfil : Page
    {
        public SeleccionarImagenPerfil()
        {
            this.InitializeComponent();
        }

        private void cambiarPersonaje(string imagen)
        {
            //CAMBIAR IMAGEN
            BitmapImage im = new BitmapImage();
            im.UriSource = new Uri(ImagenSeleccionada.BaseUri, imagen);
            ImagenSeleccionada.Source = im;           
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) //EN CASO DE QUE PASES PARAMETROS
        {
            Back.IsEnabled = this.Frame.CanGoBack; //VUELTA ATRAS

            if (e != null) //CARGAR LA IMAGEN DEL PARAMETRO
            {
                BitmapImage bitimg = e.Parameter as BitmapImage;
                ImagenSeleccionada.Source = bitimg;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DesplegablePerfil), ImagenSeleccionada.Source); //DesplegablePerfil
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/perfil.jpg");
        }

        private void Mosto_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/mosto.jpg");
        }

        private void Chica_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/chica.jpg");
        }

        private void Avestruz_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/avestruz.png");
        }

        private void Pepe_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/pepe.jpg");
        }

        private void Zeus_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/Zeus.jpg");
        }

        private void Monke_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/monke.jpg");
        }

        private void Ortega_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/ortega.jpg");
        }

        private void Boi_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/boi.jpg");
        }

        private void Sealion_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/silaion.png");
        }

        private void Calico_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/calico.jpg");
        }
        private void Scorp_Click(object sender, RoutedEventArgs e)
        {
            cambiarPersonaje("/Assets/avatarLuchador.jpg");
        }


    }
}
