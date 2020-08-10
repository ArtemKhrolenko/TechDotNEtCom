namespace DataGridAX
{
    partial class DataGridUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridUI));
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
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(18, 122);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(880, 503);
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
            this.simpleButton2.Location = new System.Drawing.Point(823, 96);
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
            this.dateNavigator1.Location = new System.Drawing.Point(18, 122);
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
            this.dateNavigator2.Location = new System.Drawing.Point(265, 122);
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
            this.DatePicker_1.Location = new System.Drawing.Point(18, 96);
            this.DatePicker_1.Name = "DatePicker_1";
            this.DatePicker_1.Properties.ReadOnly = true;
            this.DatePicker_1.Size = new System.Drawing.Size(115, 20);
            this.DatePicker_1.TabIndex = 7;
            // 
            // DatePicker_2
            // 
            this.DatePicker_2.Enabled = false;
            this.DatePicker_2.Location = new System.Drawing.Point(265, 96);
            this.DatePicker_2.Name = "DatePicker_2";
            this.DatePicker_2.Properties.ReadOnly = true;
            this.DatePicker_2.Size = new System.Drawing.Size(115, 20);
            this.DatePicker_2.TabIndex = 7;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(108, 96);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(25, 20);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "...";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(355, 96);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(25, 20);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "...";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // timeSpanEdit1
            // 
            this.timeSpanEdit1.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeSpanEdit1.Location = new System.Drawing.Point(18, 49);
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
            this.timeEdit1.Location = new System.Drawing.Point(139, 96);
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
            this.timeEdit2.Location = new System.Drawing.Point(386, 96);
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
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 77);
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
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(458, 96);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(359, 20);
            this.progressBarControl1.TabIndex = 12;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("summary", "image://svgimages/data/summary.svg");
            this.svgImageCollection1.Add("DI", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.DI"))));
            this.svgImageCollection1.Add("DO", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.DO"))));
            this.svgImageCollection1.Add("AI", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.AI"))));
            this.svgImageCollection1.Add("AO", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.AO"))));
            this.svgImageCollection1.Add("ATV", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.ATV"))));
            this.svgImageCollection1.Add("M", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.M"))));
            this.svgImageCollection1.Add("VGD", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.VGD"))));
            // 
            // DataGridUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.progressBarControl1);
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
            this.Name = "DataGridUI";
            this.Size = new System.Drawing.Size(920, 640);
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
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}
