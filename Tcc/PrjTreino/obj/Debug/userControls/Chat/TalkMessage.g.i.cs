﻿#pragma checksum "..\..\..\..\userControls\Chat\TalkMessage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DD8CB5B1D2EFE706EACFBD609E1749325FAD5AF03E1984B6A3F7A64D2A2CA351"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PrjTreino.userControls.Chat;
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


namespace PrjTreino.userControls.Chat {
    
    
    /// <summary>
    /// TalkMessage
    /// </summary>
    public partial class TalkMessage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer Scroll;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView messages;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMessage;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSendMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/PrjTreino;component/usercontrols/chat/talkmessage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
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
            
            #line 9 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
            ((PrjTreino.userControls.Chat.TalkMessage)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.UserControl_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Scroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.messages = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.txtMessage = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
            this.txtMessage.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtMessage_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSendMessage = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\userControls\Chat\TalkMessage.xaml"
            this.btnSendMessage.Click += new System.Windows.RoutedEventHandler(this.BtnSendMessage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
