﻿#pragma checksum "..\..\..\userControls\Mural.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CAFAA13C14D733B8530237E9AB2415B3548B6A647EAA5E73ECCF4E1B0BBA723F"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using PrjTreino;
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


namespace PrjTreino {
    
    
    /// <summary>
    /// Mural
    /// </summary>
    public partial class Mural : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\userControls\Mural.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Postagens;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\userControls\Mural.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard Animacao;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\userControls\Mural.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock notas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\userControls\Mural.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard Outra;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\userControls\Mural.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard Outro;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\userControls\Mural.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.TranslateTransform MyRectangle;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\userControls\Mural.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PrincipalContent;
        
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
            System.Uri resourceLocater = new System.Uri("/PrjTreino;component/usercontrols/mural.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\userControls\Mural.xaml"
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
            this.Postagens = ((System.Windows.Controls.TextBlock)(target));
            
            #line 16 "..\..\..\userControls\Mural.xaml"
            this.Postagens.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Postagens_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Animacao = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 3:
            this.notas = ((System.Windows.Controls.TextBlock)(target));
            
            #line 31 "..\..\..\userControls\Mural.xaml"
            this.notas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Notas_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Outra = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 5:
            
            #line 46 "..\..\..\userControls\Mural.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Outro = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 7:
            this.MyRectangle = ((System.Windows.Media.TranslateTransform)(target));
            return;
            case 8:
            this.PrincipalContent = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
