﻿#pragma checksum "..\..\..\..\Views\AddItemView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D6171CEC88A4C98BBB8B0401800297D8AD5DBD80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryProject.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace LibraryProject.Views {
    
    
    /// <summary>
    /// JournalView
    /// </summary>
    public partial class JournalView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Views\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxMonths;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbResult;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMonth;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddItem;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextInput;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvItems;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryProject;V1.0.0.0;component/views/additemview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddItemView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ComboBoxMonths = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.tbResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.AddMonth = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Views\AddItemView.xaml"
            this.AddMonth.Click += new System.Windows.RoutedEventHandler(this.AddMonth_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Views\AddItemView.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddItem = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Views\AddItemView.xaml"
            this.AddItem.Click += new System.Windows.RoutedEventHandler(this.AddItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lvItems = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

