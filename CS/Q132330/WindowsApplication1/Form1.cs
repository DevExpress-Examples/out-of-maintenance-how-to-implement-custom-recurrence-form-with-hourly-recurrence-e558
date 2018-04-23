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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            MyAppointmentForm frm = new MyAppointmentForm(sender as SchedulerControl, e.Appointment, e.OpenRecurrenceForm);
            e.DialogResult = frm.ShowDialog();
            e.Handled = true;
        }
    }
    public class MyAppointmentForm : AppointmentForm
    {
        public MyAppointmentForm(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
        }
        public MyAppointmentForm(SchedulerControl control, Appointment apt,bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm)
        {
        }
        protected override Form CreateAppointmentRecurrenceForm(Appointment patternCopy, FirstDayOfWeek firstDayOfWeek)
        {
            XtraForm1 frm = new XtraForm1(patternCopy, firstDayOfWeek, this.Controller);
            frm.LookAndFeel.ParentLookAndFeel = this.LookAndFeel;
            frm.ShowExceptionsRemoveMsgBox = this.Controller.AreExceptionsPresent();
            return frm;
        }
    }
}