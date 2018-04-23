using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using System.Windows.Forms;

namespace E558
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            schedulerControl1.EditAppointmentFormShowing+=schedulerControl1_EditAppointmentFormShowing;
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