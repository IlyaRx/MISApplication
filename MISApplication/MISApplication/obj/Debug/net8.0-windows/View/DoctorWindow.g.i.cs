﻿#pragma checksum "..\..\..\..\View\DoctorWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C0094037F6A07B9F80BBD236A6DFFEC3E53BD9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MISApplication.View;
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


namespace MISApplication.View {
    
    
    /// <summary>
    /// DoctorWindow
    /// </summary>
    public partial class DoctorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butStart;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl content;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton PriemRB;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton HistoryRB;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DiagnosticRB;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton HospitalRB;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butSave;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ikon;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\View\DoctorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock titleDoc;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MISApplication;component/view/doctorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\DoctorWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.butStart = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\View\DoctorWindow.xaml"
            this.butStart.Click += new System.Windows.RoutedEventHandler(this.butStart_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.content = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 3:
            this.PriemRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 64 "..\..\..\..\View\DoctorWindow.xaml"
            this.PriemRB.Checked += new System.Windows.RoutedEventHandler(this.PriemRB_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HistoryRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 68 "..\..\..\..\View\DoctorWindow.xaml"
            this.HistoryRB.Checked += new System.Windows.RoutedEventHandler(this.HistoryRB_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DiagnosticRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 72 "..\..\..\..\View\DoctorWindow.xaml"
            this.DiagnosticRB.Checked += new System.Windows.RoutedEventHandler(this.DiagnosticRB_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HospitalRB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 76 "..\..\..\..\View\DoctorWindow.xaml"
            this.HospitalRB.Checked += new System.Windows.RoutedEventHandler(this.HospitalRB_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.butSave = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\View\DoctorWindow.xaml"
            this.butSave.Click += new System.Windows.RoutedEventHandler(this.ButSave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ikon = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 9:
            this.titleDoc = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

