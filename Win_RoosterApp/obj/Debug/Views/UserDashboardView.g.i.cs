﻿#pragma checksum "..\..\..\Views\UserDashboardView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2CB8150BDEC06786BB2E68D690FEA263830955E57C6F56BC7D8336176FA62EC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using Win_RoosterApp;


namespace Win_RoosterApp {
    
    
    /// <summary>
    /// UserControl
    /// </summary>
    public partial class UserControl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Views\UserDashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMenuUsers;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\UserDashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMenuAdmin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\UserDashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\UserDashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ioGridUser;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\UserDashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ioListBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\UserDashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ioGridAdmins;
        
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
            System.Uri resourceLocater = new System.Uri("/Win_RoosterApp;component/views/userdashboardview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UserDashboardView.xaml"
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
            this.btnMenuUsers = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Views\UserDashboardView.xaml"
            this.btnMenuUsers.Click += new System.Windows.RoutedEventHandler(this.btnMenuUsers_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMenuAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\UserDashboardView.xaml"
            this.btnMenuAdmin.Click += new System.Windows.RoutedEventHandler(this.btnMenuAdmins_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\UserDashboardView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnMenuClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ioGridUser = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.ioListBox = ((System.Windows.Controls.TextBlock)(target));
            
            #line 36 "..\..\..\Views\UserDashboardView.xaml"
            this.ioListBox.Loaded += new System.Windows.RoutedEventHandler(this.ioAddUsers);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 39 "..\..\..\Views\UserDashboardView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnToAddUser);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 40 "..\..\..\Views\UserDashboardView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnToRemoveUser);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ioGridAdmins = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
