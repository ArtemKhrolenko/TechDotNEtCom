using System;
using System.Data;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
namespace DataGridAX
{
    partial class DataGridUI
    {
        private RangeControl rangeControl1;
        private DateTimeRangeControlClient dateTimeRangeControlClient1;
        private System.Windows.Forms.Panel panel2;
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.DateTimeRangeClientRuler dateTimeRangeClientRuler1 = new DevExpress.XtraEditors.DateTimeRangeClientRuler();
            DevExpress.XtraEditors.DateTimeRangeClientRuler dateTimeRangeClientRuler2 = new DevExpress.XtraEditors.DateTimeRangeClientRuler();
            this.rangeControl1 = new DevExpress.XtraEditors.RangeControl();
            this.dateTimeRangeControlClient1 = new DevExpress.XtraEditors.DateTimeRangeControlClient();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.dateNavigator2 = new DevExpress.XtraScheduler.DateNavigator();
            this.DatePicker_1 = new DevExpress.XtraEditors.TextEdit();
            this.DatePicker_2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.timeSpanEdit1 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.timeEdit2 = new DevExpress.XtraEditors.TimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rangeControl1
            // 
            this.rangeControl1.Client = this.dateTimeRangeControlClient1;
            this.rangeControl1.ContentPadding = new System.Windows.Forms.Padding(16);
            this.rangeControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangeControl1.FadeUnselectedArea = false;
            this.rangeControl1.Location = new System.Drawing.Point(0, 0);
            this.rangeControl1.Name = "rangeControl1";
            this.rangeControl1.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.Flag;
            this.rangeControl1.Size = new System.Drawing.Size(920, 99);
            this.rangeControl1.TabIndex = 0;
            this.rangeControl1.Text = "rangeControl1";
            this.rangeControl1.RangeChanged += new DevExpress.XtraEditors.RangeChangedEventHandler(this.rangeControl1_RangeChanged);
            // 
            // dateTimeRangeControlClient1
            // 
            this.dateTimeRangeControlClient1.FlagFormatString = "{0:d}";
            this.dateTimeRangeControlClient1.LabelFormatString = "";
            this.dateTimeRangeControlClient1.Maximum = new System.DateTime(2021, 1, 1, 10, 22, 25, 0);
            this.dateTimeRangeControlClient1.Minimum = new System.DateTime(2019, 1, 1, 10, 22, 25, 0);
            this.dateTimeRangeControlClient1.RangeControl = this.rangeControl1;
            dateTimeRangeClientRuler1.MainRuler = true;
            dateTimeRangeClientRuler1.MinGridDelta = 25;
            dateTimeRangeClientRuler1.ShowInContentArea = true;
            dateTimeRangeClientRuler2.AllowAdaptiveTicks = true;
            dateTimeRangeClientRuler2.DrawSeparator = DevExpress.Utils.DefaultBoolean.False;
            dateTimeRangeClientRuler2.DrawTicks = DevExpress.Utils.DefaultBoolean.False;
            dateTimeRangeClientRuler2.LabelAlignment = DevExpress.XtraEditors.Alignment.Near;
            dateTimeRangeClientRuler2.LabelPadding = new System.Windows.Forms.Padding(2, 8, 8, 8);
            dateTimeRangeClientRuler2.LabelVerticalAlignment = DevExpress.XtraEditors.DateTimeRangeClientLabelVerticalAlignment.Bottom;
            dateTimeRangeClientRuler2.ShowInContentArea = true;
            dateTimeRangeClientRuler2.Type = DevExpress.XtraEditors.DateTimeRangeClientMeasureType.Month;
            this.dateTimeRangeControlClient1.Rulers.Add(dateTimeRangeClientRuler1);
            this.dateTimeRangeControlClient1.Rulers.Add(dateTimeRangeClientRuler2);
            this.dateTimeRangeControlClient1.CustomDrawLabel += new DevExpress.XtraEditors.DateTimeRangeClientCustomDrawLabelEventHandler(this.dateTimeRangeControlClient1_CustomDrawLabel);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 34);
            this.panel2.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(17, 180);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(880, 284);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Load += new System.EventHandler(this.gridControl2_Load);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.AllowCellMerge = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(822, 145);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 20);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Submit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.DateTime = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
            this.dateNavigator1.EditValue = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator1.Location = new System.Drawing.Point(17, 180);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(241, 245);
            this.dateNavigator1.TabIndex = 6;
            this.dateNavigator1.Visible = false;
            this.dateNavigator1.DateTimeChanged += new System.EventHandler(this.dateNavigator1_DateTimeChanged);
            this.dateNavigator1.DateTimeCommit += new System.EventHandler(this.dateNavigator1_DateTimeCommit);
            // 
            // dateNavigator2
            // 
            this.dateNavigator2.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator2.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator2.DateTime = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
            this.dateNavigator2.EditValue = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
            this.dateNavigator2.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator2.Location = new System.Drawing.Point(264, 180);
            this.dateNavigator2.Name = "dateNavigator2";
            this.dateNavigator2.Size = new System.Drawing.Size(241, 245);
            this.dateNavigator2.TabIndex = 6;
            this.dateNavigator2.Visible = false;
            this.dateNavigator2.DateTimeChanged += new System.EventHandler(this.dateNavigator2_DateTimeChanged);
            this.dateNavigator2.DateTimeCommit += new System.EventHandler(this.dateNavigator2_DateTimeCommit);
            // 
            // DatePicker_1
            // 
            this.DatePicker_1.Enabled = false;
            this.DatePicker_1.Location = new System.Drawing.Point(17, 145);
            this.DatePicker_1.Name = "DatePicker_1";
            this.DatePicker_1.Properties.ReadOnly = true;
            this.DatePicker_1.Size = new System.Drawing.Size(115, 20);
            this.DatePicker_1.TabIndex = 7;
            // 
            // DatePicker_2
            // 
            this.DatePicker_2.Enabled = false;
            this.DatePicker_2.Location = new System.Drawing.Point(264, 145);
            this.DatePicker_2.Name = "DatePicker_2";
            this.DatePicker_2.Properties.ReadOnly = true;
            this.DatePicker_2.Size = new System.Drawing.Size(115, 20);
            this.DatePicker_2.TabIndex = 7;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(107, 145);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(25, 20);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "...";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(354, 145);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(25, 20);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "...";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // timeSpanEdit1
            // 
            this.timeSpanEdit1.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeSpanEdit1.Location = new System.Drawing.Point(17, 102);
            this.timeSpanEdit1.Name = "timeSpanEdit1";
            this.timeSpanEdit1.Properties.AllowEditDays = false;
            this.timeSpanEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSpanEdit1.Size = new System.Drawing.Size(100, 20);
            this.timeSpanEdit1.TabIndex = 9;
            this.timeSpanEdit1.EditValueChanged += new System.EventHandler(this.timeSpanEdit1_EditValueChanged);
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(138, 145);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(66, 20);
            this.timeEdit1.TabIndex = 10;
            this.timeEdit1.EditValueChanged += new System.EventHandler(this.timeEdit1_EditValueChanged);
            // 
            // timeEdit2
            // 
            this.timeEdit2.EditValue = new System.DateTime(2020, 7, 28, 0, 0, 0, 0);
            this.timeEdit2.Location = new System.Drawing.Point(385, 145);
            this.timeEdit2.Name = "timeEdit2";
            this.timeEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit2.Size = new System.Drawing.Size(66, 20);
            this.timeEdit2.TabIndex = 10;
            this.timeEdit2.EditValueChanged += new System.EventHandler(this.timeEdit2_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "For Last Time Span";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(-2, -1);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.progressBarControl1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBarControl1.Size = new System.Drawing.Size(71, 10);
            this.progressBarControl1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progressBarControl1);
            this.panel1.Location = new System.Drawing.Point(18, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 10);
            this.panel1.TabIndex = 14;
            // 
            // DataGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.rangeControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeEdit2);
            this.Controls.Add(this.timeEdit1);
            this.Controls.Add(this.timeSpanEdit1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.DatePicker_2);
            this.Controls.Add(this.DatePicker_1);
            this.Controls.Add(this.dateNavigator2);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panel1);
            this.Name = "DataGridUI";
            this.Size = new System.Drawing.Size(920, 640);
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dateTimeRangeControlClient1_CustomDrawLabel(object sender, DateTimeRangeClientCustomDrawLabelEventArgs e)
        {
            if (e.Ruler.Type == DateTimeRangeClientMeasureType.Month &&
                (e.PrevValue == null || e.PrevValue.Value.Year != e.Value.Year))
            {
                e.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
                Size sz = e.Cache.CalcTextSize(e.Text, e.Appearance.Font).ToSize();
                e.Bounds = new System.Drawing.Rectangle(e.Bounds.Location, sz);
            }
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator2;
        private DevExpress.XtraEditors.TextEdit DatePicker_1;
        private DevExpress.XtraEditors.TextEdit DatePicker_2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TimeSpanEdit timeSpanEdit1;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.TimeEdit timeEdit2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Panel panel1;        
       
    }
}
