﻿#pragma checksum "..\..\..\Views\PrintJobView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A9B19EF7E9DD7449EFE8DDF2D5156A5381FB6E8A556F397DCA258DE4C4087E58"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Dragablz;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfFramework.Controls;
using WpfFramework.Converters;
using WpfFramework.Models;
using WpfFramework.ViewModels;
using WpfFramework.Views;


namespace WpfFramework.Views {
    
    
    /// <summary>
    /// PrintJobView
    /// </summary>
    public partial class PrintJobView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Views\PrintJobView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/3dPrintCostCalculator2;component/views/printjobview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PrintJobView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            
            #line 67 "..\..\..\Views\PrintJobView.xaml"
            ((System.Windows.Controls.DataGrid)(target)).AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.DataGrid_Drop));
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 72 "..\..\..\Views\PrintJobView.xaml"
            ((System.Windows.Controls.ContextMenu)(target)).Opened += new System.Windows.RoutedEventHandler(this.ContextMenu_Opened);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 173 "..\..\..\Views\PrintJobView.xaml"
            ((System.Windows.Controls.ContextMenu)(target)).Opened += new System.Windows.RoutedEventHandler(this.ContextMenu_Opened);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
