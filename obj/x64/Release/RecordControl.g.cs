﻿#pragma checksum "D:\User\Doc\MomeNikki\RecordControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "377EC12F20B73690946E4B45ADABAA685FE4AB3C2698D254A506DA85FC003EEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MomeNikki
{
    partial class RecordControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class RecordControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRecordControl_Bindings
        {
            private global::MomeNikki.RecordControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBox obj13;

            private RecordControl_obj1_BindingsTracking bindingsTracking;

            public RecordControl_obj1_Bindings()
            {
                this.bindingsTracking = new RecordControl_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // RecordControl.xaml line 13
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // RecordControl.xaml line 15
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // RecordControl.xaml line 16
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6: // RecordControl.xaml line 17
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // RecordControl.xaml line 18
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // RecordControl.xaml line 19
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13: // RecordControl.xaml line 31
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_13(this.obj13);
                        break;
                    default:
                        break;
                }
            }

            // IRecordControl_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::MomeNikki.RecordControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MomeNikki.RecordControl obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_pageNikki(obj.pageNikki, phase);
                    }
                }
            }
            private void Update_pageNikki(global::MomeNikki.Nikki obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_pageNikki_RecordYear(obj.RecordYear, phase);
                        this.Update_pageNikki_RecordMonth(obj.RecordMonth, phase);
                        this.Update_pageNikki_RecordDay(obj.RecordDay, phase);
                        this.Update_pageNikki_RecordHour(obj.RecordHour, phase);
                        this.Update_pageNikki_RecordMinute(obj.RecordMinute, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_pageNikki_UniqueId(obj.UniqueId, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_pageNikki_RecordText(obj.RecordText, phase);
                    }
                }
            }
            private void Update_pageNikki_RecordYear(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RecordControl.xaml line 13
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj.ToString(), null);
                }
            }
            private void Update_pageNikki_RecordMonth(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RecordControl.xaml line 15
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj.ToString(), null);
                }
            }
            private void Update_pageNikki_RecordDay(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RecordControl.xaml line 16
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj.ToString(), null);
                }
            }
            private void Update_pageNikki_RecordHour(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RecordControl.xaml line 17
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj.ToString(), null);
                }
            }
            private void Update_pageNikki_RecordMinute(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RecordControl.xaml line 18
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj.ToString(), null);
                }
            }
            private void Update_pageNikki_UniqueId(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RecordControl.xaml line 19
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                }
            }
            private void Update_pageNikki_RecordText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RecordControl.xaml line 31
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj13, obj, null);
                }
            }
            private void UpdateTwoWay_13_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.pageNikki != null)
                        {
                            this.dataRoot.pageNikki.RecordText = this.obj13.Text;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class RecordControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<RecordControl_obj1_Bindings> weakRefToBindingObj; 

                public RecordControl_obj1_BindingsTracking(RecordControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<RecordControl_obj1_Bindings>(obj);
                }

                public RecordControl_obj1_Bindings TryGetBindingObject()
                {
                    RecordControl_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

                public void RegisterTwoWayListener_13(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_13_Text();
                        }
                    };
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // RecordControl.xaml line 12
                {
                    this.MainPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 3: // RecordControl.xaml line 13
                {
                    this.YearDisplayBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // RecordControl.xaml line 15
                {
                    this.MonthDisplayBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // RecordControl.xaml line 16
                {
                    this.DayDisplayBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // RecordControl.xaml line 17
                {
                    this.HourDisplayBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // RecordControl.xaml line 18
                {
                    this.MinuteDisplayBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // RecordControl.xaml line 19
                {
                    this.UniIdBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // RecordControl.xaml line 21
                {
                    this.DateEditor = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 10: // RecordControl.xaml line 22
                {
                    this.TimeEditor = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 11: // RecordControl.xaml line 24
                {
                    this.EditButtom = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.EditButtom).Click += this.EditButtom_Click;
                }
                break;
            case 12: // RecordControl.xaml line 27
                {
                    this.DeleteButtom = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeleteButtom).Click += this.DeleteButtom_Click;
                }
                break;
            case 13: // RecordControl.xaml line 31
                {
                    this.RecordMainBody = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // RecordControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    RecordControl_obj1_Bindings bindings = new RecordControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

