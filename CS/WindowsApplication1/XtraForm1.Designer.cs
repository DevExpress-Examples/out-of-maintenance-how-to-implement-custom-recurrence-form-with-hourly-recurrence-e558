namespace WindowsApplication1
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.hourRecurrenceControl1 = new WindowsApplication1.HourRecurrenceControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRecurrencePattern
            // 
            this.grpRecurrencePattern.Controls.Add(this.hourRecurrenceControl1);
            this.grpRecurrencePattern.Controls.Add(this.checkEdit1);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(16, 120);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.checkEdit1.Properties.Caption = "Hourly";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit1.Properties.RadioGroupIndex = 1;
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 13;
            this.checkEdit1.TabStop = false;
            this.checkEdit1.Tag = "Hourly";
            // 
            // hourRecurrenceControl1
            // 
            this.hourRecurrenceControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hourRecurrenceControl1.Appearance.Options.UseBackColor = true;
            this.hourRecurrenceControl1.Location = new System.Drawing.Point(80, 24);
            this.hourRecurrenceControl1.Name = "hourRecurrenceControl1";
            this.hourRecurrenceControl1.Size = new System.Drawing.Size(368, 96);
            this.hourRecurrenceControl1.TabIndex = 14;
            this.hourRecurrenceControl1.Visible = false;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 390);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
      
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private HourRecurrenceControl hourRecurrenceControl1;
     }
}