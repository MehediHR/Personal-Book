﻿#pragma checksum "..\..\forgot.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "901A5B22AB47BC321513396F251CF682AE08EF76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Project3._1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Project3._1 {
    
    
    /// <summary>
    /// forgot
    /// </summary>
    public partial class forgot : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\forgot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uname;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\forgot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fkey;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\forgot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pass;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\forgot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox cpass;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\forgot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\forgot.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
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
            System.Uri resourceLocater = new System.Uri("/Project3.1;component/forgot.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\forgot.xaml"
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
            
            #line 9 "..\..\forgot.xaml"
            ((Project3._1.forgot)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.move);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.fkey = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.pass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.cpass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\forgot.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.savebtn);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\forgot.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.btncls);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 44 "..\..\forgot.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clbtn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

