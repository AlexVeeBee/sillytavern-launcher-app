﻿#pragma checksum "K:\Scripts\CS-WINUI3\st-installer-launcher\st-installer-launcher\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F95788CADCEE5FF69F70133A29D95E579A592AC637317D9A34AB8A225E0A4C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace st_installer_launcher.Views
{
    partial class MainPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 9
                {
                    this.ContentArea = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 11
                {
                    this.APP_VERSION_INFOBAR = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.InfoBar>(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 17
                {
                    this.APP_FOLDER_PATHMISSING = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.InfoBar>(target);
                }
                break;
            case 5: // Views\MainPage.xaml line 24
                {
                    this.AppLuncher = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                    ((global::Microsoft.UI.Xaml.Controls.StackPanel)this.AppLuncher).SizeChanged += this.AppLuncherSizechange;
                }
                break;
            case 6: // Views\MainPage.xaml line 80
                {
                    this.Home_AppSettings = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                    ((global::Microsoft.UI.Xaml.Controls.StackPanel)this.Home_AppSettings).SizeChanged += this.Home_AppSettings_SizeChanged;
                }
                break;
            case 7: // Views\MainPage.xaml line 76
                {
                    global::Microsoft.UI.Xaml.Controls.Button element7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element7).Click += this.ButtonCheckApps;
                }
                break;
            case 8: // Views\MainPage.xaml line 77
                {
                    this.appslastcheck = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 9: // Views\MainPage.xaml line 78
                {
                    this.apps_progress = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ProgressRing>(target);
                }
                break;
            case 10: // Views\MainPage.xaml line 64
                {
                    this.sevenzipstat = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 11: // Views\MainPage.xaml line 56
                {
                    this.nodestat = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 12: // Views\MainPage.xaml line 47
                {
                    this.gitstat = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2310")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

