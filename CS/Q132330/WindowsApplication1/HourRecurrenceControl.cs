// Developer Express Code Central Example:
// How to implement custom Recurrence form with hourly recurrence
// 
// This sample illustrates how to create custom Recurrence form, which contains
// Hourly recurrence pattern
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E558

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.UI;

namespace WindowsApplication1
{
    public partial class HourRecurrenceControl : RecurrenceControlBase
    {
        public HourRecurrenceControl():base()
        {
            InitializeComponent();
            this.UpdateControlsCore();
            this.SubscribeControlsEvents();

        }
        protected override void SubscribeControlsEvents()
        {
            base.SubscribeControlsEvents();
            this.spinEdit1.EditValueChanged += new EventHandler(spinEdit1_EditValueChanged);
        }
        protected override void UnsubscribeControlsEvents()
        {
            base.UnsubscribeControlsEvents();
            this.spinEdit1.EditValueChanged -= new EventHandler(spinEdit1_EditValueChanged);
        }

        void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            base.RecurrenceInfo.Periodicity = base.Validator.GetIntegerValue(this.spinEdit1.EditValue);
        }
        protected override void UpdateControlsCore()
        {
            base.UpdateControlsCore();
            this.spinEdit1.EditValue = base.RecurrenceInfo.Periodicity;
        }
    }
}
