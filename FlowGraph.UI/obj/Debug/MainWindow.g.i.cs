﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E53B9BAC2ABCF6868B8C89A9567F3EFCEEB89380"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdornedControl;
using FlowGraph.UI;
using FlowGraph.UI.NetworkModel;
using FlowGraph.UI.Toolbar;
using NetworkUI;
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
using ZoomAndPan;


namespace FlowGraph.UI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FlowGraph.UI.MainWindow mainWindow;
        
        #line default
        #line hidden
        
        
        #line 683 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ZoomAndPan.ZoomAndPanControl zoomAndPanControl;
        
        #line default
        #line hidden
        
        
        #line 717 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NetworkUI.NetworkView networkControl;
        
        #line default
        #line hidden
        
        
        #line 740 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas dragZoomCanvas;
        
        #line default
        #line hidden
        
        
        #line 744 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border dragZoomBorder;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowGraph.UI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.mainWindow = ((FlowGraph.UI.MainWindow)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.mainWindow.Loaded += new System.Windows.RoutedEventHandler(this.MainWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 404 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteSelectedNodes_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 408 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CreateNode_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 412 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteNode_Executed);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 416 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteConnection_Executed);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 420 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ZoomOut_Executed);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 424 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ZoomIn_Executed);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 428 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.JumpBackToPrevZoom_Executed);
            
            #line default
            #line hidden
            
            #line 429 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.JumpBackToPrevZoom_CanExecuted);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 433 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.FitContent_Executed);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 437 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Fill_Executed);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 441 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OneHundredPercent_Executed);
            
            #line default
            #line hidden
            return;
            case 13:
            this.zoomAndPanControl = ((ZoomAndPan.ZoomAndPanControl)(target));
            return;
            case 14:
            this.networkControl = ((NetworkUI.NetworkView)(target));
            
            #line 724 "..\..\MainWindow.xaml"
            this.networkControl.ConnectionDragStarted += new NetworkUI.ConnectionDragStartedEventHandler(this.networkControl_ConnectionDragStarted);
            
            #line default
            #line hidden
            
            #line 725 "..\..\MainWindow.xaml"
            this.networkControl.QueryConnectionFeedback += new NetworkUI.QueryConnectionFeedbackEventHandler(this.networkControl_QueryConnectionFeedback);
            
            #line default
            #line hidden
            
            #line 726 "..\..\MainWindow.xaml"
            this.networkControl.ConnectionDragging += new NetworkUI.ConnectionDraggingEventHandler(this.networkControl_ConnectionDragging);
            
            #line default
            #line hidden
            
            #line 727 "..\..\MainWindow.xaml"
            this.networkControl.ConnectionDragCompleted += new NetworkUI.ConnectionDragCompletedEventHandler(this.networkControl_ConnectionDragCompleted);
            
            #line default
            #line hidden
            
            #line 729 "..\..\MainWindow.xaml"
            this.networkControl.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.networkControl_MouseDown);
            
            #line default
            #line hidden
            
            #line 730 "..\..\MainWindow.xaml"
            this.networkControl.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.networkControl_MouseUp);
            
            #line default
            #line hidden
            
            #line 731 "..\..\MainWindow.xaml"
            this.networkControl.MouseMove += new System.Windows.Input.MouseEventHandler(this.networkControl_MouseMove);
            
            #line default
            #line hidden
            
            #line 732 "..\..\MainWindow.xaml"
            this.networkControl.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.networkControl_MouseWheel);
            
            #line default
            #line hidden
            return;
            case 15:
            this.dragZoomCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 16:
            this.dragZoomBorder = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 279 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Node_SizeChanged);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

