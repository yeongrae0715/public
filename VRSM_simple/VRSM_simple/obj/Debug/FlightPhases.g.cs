﻿#pragma checksum "..\..\FlightPhases.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FE2719362198802A02FBD5E9E827DC3FF8FB4C9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using VRSM_simple;


namespace VRSM_simple {
    
    
    /// <summary>
    /// FlightPhases
    /// </summary>
    public partial class FlightPhases : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\FlightPhases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_Before_Takeoff;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FlightPhases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_Taxi_And_Takeoff;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\FlightPhases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_In_Flight;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\FlightPhases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_Descent_And_BeforeLanding;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\FlightPhases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_After_Landing;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\FlightPhases.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Phase_Start_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/VRSM_simple;component/flightphases.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FlightPhases.xaml"
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
            this.RB_Before_Takeoff = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.RB_Taxi_And_Takeoff = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.RB_In_Flight = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.RB_Descent_And_BeforeLanding = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.RB_After_Landing = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.Phase_Start_Button = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\FlightPhases.xaml"
            this.Phase_Start_Button.Click += new System.Windows.RoutedEventHandler(this.Phase_Start_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
