#pragma checksum "..\..\ReadTrain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49139F147161A5117B9E8FB817E504AC530AE81C8269C06E86C9B988E8811A41"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Railway;
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


namespace Railway {
    
    
    /// <summary>
    /// ReadTrain
    /// </summary>
    public partial class ReadTrain : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\ReadTrain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewTrain;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ReadTrain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UndoDeleteTrain;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ReadTrain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RedoDeleteTrain;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ReadTrain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ReadTrainScrollViewer;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ReadTrain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ReadTrainStackPanel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ReadTrain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ReadTrainGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Railway;component/readtrain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReadTrain.xaml"
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
            this.AddNewTrain = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ReadTrain.xaml"
            this.AddNewTrain.Click += new System.Windows.RoutedEventHandler(this.AddNewTrain_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UndoDeleteTrain = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ReadTrain.xaml"
            this.UndoDeleteTrain.Click += new System.Windows.RoutedEventHandler(this.UndoDeleteTrain_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RedoDeleteTrain = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ReadTrain.xaml"
            this.RedoDeleteTrain.Click += new System.Windows.RoutedEventHandler(this.RedoDeleteTrain_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ReadTrainScrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.ReadTrainStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.ReadTrainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

