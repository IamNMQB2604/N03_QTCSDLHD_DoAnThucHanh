﻿#pragma checksum "..\..\..\XemChiTietChuyenBay.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B5B23220566848330CD74CB9A68DDE2ABE9DDB5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
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


namespace GUI {
    
    
    /// <summary>
    /// XemChiTietChuyenBay
    /// </summary>
    public partial class XemChiTietChuyenBay : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\XemChiTietChuyenBay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvThongTinChuyenBay;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\XemChiTietChuyenBay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbChiTietChuyenBay;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\XemChiTietChuyenBay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMoTa;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\XemChiTietChuyenBay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDiemDung;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\XemChiTietChuyenBay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuayLai;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUI;component/xemchitietchuyenbay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\XemChiTietChuyenBay.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dgvThongTinChuyenBay = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\XemChiTietChuyenBay.xaml"
            this.dgvThongTinChuyenBay.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvThongTinChuyenBay_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbChiTietChuyenBay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbMoTa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbDiemDung = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnQuayLai = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\XemChiTietChuyenBay.xaml"
            this.btnQuayLai.Click += new System.Windows.RoutedEventHandler(this.btnQuayLai_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

