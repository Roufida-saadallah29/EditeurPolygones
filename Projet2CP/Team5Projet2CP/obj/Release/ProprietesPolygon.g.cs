﻿#pragma checksum "..\..\ProprietesPolygon.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F019B330A5BA20D2576F403604921C5F564D61140643B67749574140738BBE5A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Team5Projet2CP;


namespace Team5Projet2CP {
    
    
    /// <summary>
    /// ProprietesPolygon
    /// </summary>
    public partial class ProprietesPolygon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ProprietesPolygon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NBCTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProprietesPolygon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ProprietesPolygon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CxTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ProprietesPolygon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CyTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ProprietesPolygon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ProprietesPolygon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ProprietesPolygon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Team5Projet2CP;component/proprietespolygon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProprietesPolygon.xaml"
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
            
            #line 9 "..\..\ProprietesPolygon.xaml"
            ((Team5Projet2CP.ProprietesPolygon)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NBCTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CxTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.sTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ProprietesPolygon.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.okButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 39 "..\..\ProprietesPolygon.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Mode_Plain);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 40 "..\..\ProprietesPolygon.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Mode_NonPlain);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

