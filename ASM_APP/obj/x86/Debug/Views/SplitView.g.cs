﻿#pragma checksum "C:\Users\win10pro\source\repos\ASM_APP\ASM_APP\Views\SplitView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "971386CD71A1036B7682B62D05AA07DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASM_APP.Views
{
    partial class SplitView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\SplitView.xaml line 12
                {
                    this.SplitVia = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // Views\SplitView.xaml line 45
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Button_Click;
                }
                break;
            case 4: // Views\SplitView.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element4 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element4).Click += this.RadioButton_Click;
                }
                break;
            case 5: // Views\SplitView.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element5 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element5).Click += this.RadioButton_Click;
                }
                break;
            case 6: // Views\SplitView.xaml line 27
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element6 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element6).Click += this.RadioButton_Click;
                }
                break;
            case 7: // Views\SplitView.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element7 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element7).Click += this.RadioButton_Click;
                }
                break;
            case 8: // Views\SplitView.xaml line 42
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

