﻿#pragma checksum "..\..\PrésetationLog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F21E8BA711E83FB268FAA806E1C09E42D10920BD22E039DB411B16C9F95D8F68"
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
    /// PrésetationLog
    /// </summary>
    public partial class PrésetationLog : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 360 "..\..\PrésetationLog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _mainFrame4;
        
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
            System.Uri resourceLocater = new System.Uri("/Team5Projet2CP;component/pr%c3%a9setationlog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PrésetationLog.xaml"
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
            
            #line 56 "..\..\PrésetationLog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Accueil_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 71 "..\..\PrésetationLog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.apropos_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this._mainFrame4 = ((System.Windows.Controls.Frame)(target));
            
            #line 360 "..\..\PrésetationLog.xaml"
            this._mainFrame4.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this._mainFrame_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

