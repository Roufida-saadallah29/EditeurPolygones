﻿#pragma checksum "..\..\ColorPicker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "347DCAC626F05AFE9D48DAED10DCBD721187B6B498C9E43FF7B80D731A76D65B"
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
    /// ColorPicker
    /// </summary>
    public partial class ColorPicker : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas ColorPickerCanvas;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ColorDescrTBlock;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle sampleRec;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxR;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxG;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderR;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderG;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderB;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FillRB;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OutRB;
        
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
            System.Uri resourceLocater = new System.Uri("/Team5Projet2CP;component/colorpicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ColorPicker.xaml"
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
            
            #line 8 "..\..\ColorPicker.xaml"
            ((Team5Projet2CP.ColorPicker)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ColorPickerCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 15 "..\..\ColorPicker.xaml"
            this.ColorPickerCanvas.Loaded += new System.Windows.RoutedEventHandler(this.ColorPickerCanvas_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ColorDescrTBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ColorPicker.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.sampleRec = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.TBoxR = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBoxG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TBoxB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.SliderR = ((System.Windows.Controls.Slider)(target));
            
            #line 31 "..\..\ColorPicker.xaml"
            this.SliderR.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderR_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SliderG = ((System.Windows.Controls.Slider)(target));
            
            #line 32 "..\..\ColorPicker.xaml"
            this.SliderG.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderG_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SliderB = ((System.Windows.Controls.Slider)(target));
            
            #line 33 "..\..\ColorPicker.xaml"
            this.SliderB.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderB_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.FillRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 37 "..\..\ColorPicker.xaml"
            this.FillRB.Checked += new System.Windows.RoutedEventHandler(this.FillRB_Checked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.OutRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 38 "..\..\ColorPicker.xaml"
            this.OutRB.Checked += new System.Windows.RoutedEventHandler(this.OutRB_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
