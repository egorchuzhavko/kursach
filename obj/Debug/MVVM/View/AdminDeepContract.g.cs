﻿#pragma checksum "..\..\..\..\MVVM\View\AdminDeepContract.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6281210B6675C9D7F13E0FA5DEA66569D773AF2F525D2E93801024B92FB75DB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using project.MVVM.View;


namespace project.MVVM.View {
    
    
    /// <summary>
    /// AdminDeepContract
    /// </summary>
    public partial class AdminDeepContract : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdofUser;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel IdPanel;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IdofContract;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateStart;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateEnd;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Status;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdofStuf;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveChanges;
        
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
            System.Uri resourceLocater = new System.Uri("/project;component/mvvm/view/admindeepcontract.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
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
            
            #line 15 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IdofUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.IdPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.IdofContract = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DateStart = ((System.Windows.Controls.DatePicker)(target));
            
            #line 66 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
            this.DateStart.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DateStart_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DateEnd = ((System.Windows.Controls.DatePicker)(target));
            
            #line 72 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
            this.DateEnd.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DateEnd_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Status = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.IdofStuf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.SaveChanges = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\MVVM\View\AdminDeepContract.xaml"
            this.SaveChanges.Click += new System.Windows.RoutedEventHandler(this.SaveChanges_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
