﻿#pragma checksum "..\..\..\Page\StatisticsControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "97E9958BC57D7D88FD917D067EF91D9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.DataPager;
using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Editors.ExpressionEditor;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Flyout;
using DevExpress.Xpf.Editors.Popups;
using DevExpress.Xpf.Editors.Popups.Calendar;
using DevExpress.Xpf.Editors.RangeControl;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Editors.Settings.Extension;
using DevExpress.Xpf.Editors.Validation;
using DevExpress.Xpf.Gauges;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.ConditionalFormatting;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.TreeList;
using FireWall;
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


namespace FireWall {
    
    
    /// <summary>
    /// StatisticsControl
    /// </summary>
    public partial class StatisticsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.DateEdit QueryDate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.ComboBoxEdit FwName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.ComboBoxEdit ProtectedIP;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.ComboBoxEdit StateName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Querybutton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exportbutton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.GridControl StatisData;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.TableView view;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Returnbutton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.CheckEdit ShowLine;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.CheckEdit ShowBar;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.ChartControl IPchartControl;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.PieSeries2D pie;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.ChartControl DatechartControl;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.BarSideBySideSeries2D barSeries;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Page\StatisticsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Charts.LineSeries2D line;
        
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
            System.Uri resourceLocater = new System.Uri("/FireWall;component/page/statisticscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page\StatisticsControl.xaml"
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
            
            #line 14 "..\..\..\Page\StatisticsControl.xaml"
            ((FireWall.StatisticsControl)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.QueryDate = ((DevExpress.Xpf.Editors.DateEdit)(target));
            
            #line 21 "..\..\..\Page\StatisticsControl.xaml"
            this.QueryDate.PopupOpened += new System.Windows.RoutedEventHandler(this.clear);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FwName = ((DevExpress.Xpf.Editors.ComboBoxEdit)(target));
            
            #line 25 "..\..\..\Page\StatisticsControl.xaml"
            this.FwName.PopupOpened += new System.Windows.RoutedEventHandler(this.clear);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProtectedIP = ((DevExpress.Xpf.Editors.ComboBoxEdit)(target));
            
            #line 29 "..\..\..\Page\StatisticsControl.xaml"
            this.ProtectedIP.PopupOpened += new System.Windows.RoutedEventHandler(this.clear);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StateName = ((DevExpress.Xpf.Editors.ComboBoxEdit)(target));
            
            #line 33 "..\..\..\Page\StatisticsControl.xaml"
            this.StateName.PopupOpened += new System.Windows.RoutedEventHandler(this.clear);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Querybutton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Page\StatisticsControl.xaml"
            this.Querybutton.Click += new System.Windows.RoutedEventHandler(this.Querybutton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exportbutton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Page\StatisticsControl.xaml"
            this.Exportbutton.Click += new System.Windows.RoutedEventHandler(this.Exportbutton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.StatisData = ((DevExpress.Xpf.Grid.GridControl)(target));
            return;
            case 9:
            this.view = ((DevExpress.Xpf.Grid.TableView)(target));
            
            #line 42 "..\..\..\Page\StatisticsControl.xaml"
            this.view.RowDoubleClick += new DevExpress.Xpf.Grid.RowDoubleClickEventHandler(this.RowDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Returnbutton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Page\StatisticsControl.xaml"
            this.Returnbutton.Click += new System.Windows.RoutedEventHandler(this.Returnbutton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ShowLine = ((DevExpress.Xpf.Editors.CheckEdit)(target));
            
            #line 47 "..\..\..\Page\StatisticsControl.xaml"
            this.ShowLine.Checked += new System.Windows.RoutedEventHandler(this.ShowLine_Checked);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\Page\StatisticsControl.xaml"
            this.ShowLine.Unchecked += new System.Windows.RoutedEventHandler(this.ShowLine_Unchecked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ShowBar = ((DevExpress.Xpf.Editors.CheckEdit)(target));
            
            #line 48 "..\..\..\Page\StatisticsControl.xaml"
            this.ShowBar.Checked += new System.Windows.RoutedEventHandler(this.ShowBar_Checked);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\Page\StatisticsControl.xaml"
            this.ShowBar.Unchecked += new System.Windows.RoutedEventHandler(this.ShowBar_Unchecked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.IPchartControl = ((DevExpress.Xpf.Charts.ChartControl)(target));
            return;
            case 14:
            this.pie = ((DevExpress.Xpf.Charts.PieSeries2D)(target));
            return;
            case 15:
            this.DatechartControl = ((DevExpress.Xpf.Charts.ChartControl)(target));
            return;
            case 16:
            this.barSeries = ((DevExpress.Xpf.Charts.BarSideBySideSeries2D)(target));
            return;
            case 17:
            this.line = ((DevExpress.Xpf.Charts.LineSeries2D)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
