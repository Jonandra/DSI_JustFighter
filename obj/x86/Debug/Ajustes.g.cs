﻿#pragma checksum "C:\Users\javie\Documents\UNI\DSI\DSI_JustFighter\Ajustes.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F0741D939ACB3EE00CFD7D96AF557EF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSI_JustFighter
{
    partial class Ajustes : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Ajustes.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).KeyDown += this.Grid_KeyDown;
                }
                break;
            case 3: // Ajustes.xaml line 45
                {
                    this.vGen = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Ajustes.xaml line 47
                {
                    this.musica = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Ajustes.xaml line 49
                {
                    this.eSonido = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Ajustes.xaml line 51
                {
                    this.graficos = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Ajustes.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element7 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element7).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            case 8: // Ajustes.xaml line 31
                {
                    this.Español = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 9: // Ajustes.xaml line 34
                {
                    this.Ingles = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 10: // Ajustes.xaml line 37
                {
                    this.Frances = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 11: // Ajustes.xaml line 38
                {
                    this.Francés = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Ajustes.xaml line 35
                {
                    this.Inglés = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Ajustes.xaml line 18
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.Button_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

