﻿#pragma checksum "C:\Users\ARIALBLAK\Desktop\DSI_JustFighter\CombateUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "12047677FE3B12EA31E4F361847C3137"
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
    partial class CombateUI : 
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
            case 2: // CombateUI.xaml line 33
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Button_Click;
                }
                break;
            case 3: // CombateUI.xaml line 73
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.ContentControl_Click;
                }
                break;
            case 4: // CombateUI.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.Player_Click;
                }
                break;
            case 5: // CombateUI.xaml line 60
                {
                    this.Bar2 = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6: // CombateUI.xaml line 48
                {
                    this.Bar1 = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 7: // CombateUI.xaml line 41
                {
                    this.Perfil = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8: // CombateUI.xaml line 29
                {
                    this.player1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // CombateUI.xaml line 30
                {
                    this.player2 = (global::Windows.UI.Xaml.Controls.Image)(target);
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

