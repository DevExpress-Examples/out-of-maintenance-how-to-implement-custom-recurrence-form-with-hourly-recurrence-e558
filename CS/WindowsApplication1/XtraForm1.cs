using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Forms;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler;

namespace WindowsApplication1
{
    public partial class XtraForm1 : AppointmentRecurrenceForm
    {
        public XtraForm1(Appointment pattern, FirstDayOfWeek fdow, AppointmentFormController afc)
            : base(pattern, fdow, afc)
        {
            //InitializeComponent();
            checkEdit1.Tag = RecurrenceType.Hourly;
            UnsubscribeRecurrenceTypeControlsEvents();
            SubscribeRecurrenceTypeControlsEvents();
            SetRecurrenceType(this.GetRecurrenceType());
        }

        protected override void InitializeControls(FirstDayOfWeek firstDayOfWeek) {
            InitializeComponent();
            base.InitializeControls(firstDayOfWeek);
        }

        protected override void SubscribeRecurrenceTypeControlsEvents()
        {
            base.SubscribeRecurrenceTypeControlsEvents();
            if(checkEdit1 != null)
                checkEdit1.EditValueChanged += new EventHandler(this.chkRecurrenceTypeChanged);
        }
        protected override void UnsubscribeRecurrenceTypeControlsEvents()
        {
            base.UnsubscribeRecurrenceTypeControlsEvents();
            if (checkEdit1 != null)
                checkEdit1.EditValueChanged -= new EventHandler(this.chkRecurrenceTypeChanged);
        }
        protected override void ChangeCurrentRecurrenceControl()
        {
            if (this.CurrentRecurrenceControl != null)
            {
                this.CurrentRecurrenceControl.Visible = false;
            }
            switch (this.GetRecurrenceType())
            {
                case RecurrenceType.Daily:
                    this.CurrentRecurrenceControl = this.dailyRecurrenceControl1;
                    break;

                case RecurrenceType.Weekly:
                    this.CurrentRecurrenceControl = this.weeklyRecurrenceControl1;
                    break;

                case RecurrenceType.Monthly:
                    this.CurrentRecurrenceControl = this.monthlyRecurrenceControl1;
                    break;
                case RecurrenceType.Hourly:
                    this.CurrentRecurrenceControl = this.hourRecurrenceControl1;
                    break;

                default:
                    this.CurrentRecurrenceControl = this.yearlyRecurrenceControl1;
                    break;
            }
           
            this.CurrentRecurrenceControl.Visible = true;

        }
        protected override void SetRecurrenceType(RecurrenceType type)
        {
            if (type == RecurrenceType.Hourly && checkEdit1 != null)
            {
                    checkEdit1.Checked = true;
                    return;
            }
                base.SetRecurrenceType(type);
        }

        


    }
}