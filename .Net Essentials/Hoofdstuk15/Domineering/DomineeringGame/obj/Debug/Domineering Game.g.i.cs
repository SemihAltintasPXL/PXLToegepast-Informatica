﻿#pragma checksum "..\..\Domineering Game.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4DF69C8CC15C2FF808814815A403945FF0223CDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DomineeringGame;
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


namespace DomineeringGame {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem startAGameMenuItem;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem movesMenuItem;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem exitMenuItem;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas gameCanvas;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label playerTurnLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label XCoordinateLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label YCoordinateLabel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Domineering Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label positionLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/DomineeringGame;component/domineering%20game.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Domineering Game.xaml"
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
            this.startAGameMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 11 "..\..\Domineering Game.xaml"
            this.startAGameMenuItem.Click += new System.Windows.RoutedEventHandler(this.startAGameMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.movesMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\Domineering Game.xaml"
            this.movesMenuItem.Click += new System.Windows.RoutedEventHandler(this.movesMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.exitMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\Domineering Game.xaml"
            this.exitMenuItem.Click += new System.Windows.RoutedEventHandler(this.exitMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gameCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 16 "..\..\Domineering Game.xaml"
            this.gameCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.UIElement_OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 5:
            this.playerTurnLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.XCoordinateLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.YCoordinateLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.positionLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

