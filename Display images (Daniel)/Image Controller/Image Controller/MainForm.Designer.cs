namespace Image_Controller
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.datePanel = new System.Windows.Forms.Panel();
            this.dateDateInfo = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeInfo = new System.Windows.Forms.Label();
            this.timeDateInfo = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeButton = new System.Windows.Forms.Button();
            this.timeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHeader = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.secPanel = new System.Windows.Forms.Panel();
            this.secInfo = new System.Windows.Forms.Label();
            this.secDateInfo = new System.Windows.Forms.Label();
            this.secDatePicker = new System.Windows.Forms.DateTimePicker();
            this.secPicker = new System.Windows.Forms.DateTimePicker();
            this.secTimeInfo = new System.Windows.Forms.Label();
            this.dateTimeSecButton = new System.Windows.Forms.Button();
            this.secTimePicker = new System.Windows.Forms.DateTimePicker();
            this.restButton = new System.Windows.Forms.Button();
            this.dateHeader = new System.Windows.Forms.Label();
            this.searchHeader = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.openFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.imageCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.datePanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.secPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColumnTime,
            this.ColumnSecond,
            this.dataGridViewImageColumn1});
            this.table.Location = new System.Drawing.Point(12, 31);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.table.RowTemplate.Height = 256;
            this.table.Size = new System.Drawing.Size(550, 650);
            this.table.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 65F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // ColumnTime
            // 
            this.ColumnTime.FillWeight = 35F;
            this.ColumnTime.Frozen = true;
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.MaxInputLength = 5;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTime.Width = 35;
            // 
            // ColumnSecond
            // 
            this.ColumnSecond.FillWeight = 35F;
            this.ColumnSecond.Frozen = true;
            this.ColumnSecond.HeaderText = "Sec";
            this.ColumnSecond.Name = "ColumnSecond";
            this.ColumnSecond.ReadOnly = true;
            this.ColumnSecond.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSecond.Width = 35;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 256F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "Images";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 256;
            // 
            // dateButton
            // 
            this.dateButton.Location = new System.Drawing.Point(13, 75);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(150, 40);
            this.dateButton.TabIndex = 13;
            this.dateButton.Text = "Search";
            this.dateButton.UseVisualStyleBackColor = true;
            this.dateButton.Click += new System.EventHandler(this.dateButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(63, 30);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(100, 22);
            this.datePicker.TabIndex = 14;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // datePanel
            // 
            this.datePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datePanel.Controls.Add(this.dateDateInfo);
            this.datePanel.Controls.Add(this.dateButton);
            this.datePanel.Controls.Add(this.datePicker);
            this.datePanel.Location = new System.Drawing.Point(8, 26);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(180, 140);
            this.datePanel.TabIndex = 16;
            // 
            // dateDateInfo
            // 
            this.dateDateInfo.AutoSize = true;
            this.dateDateInfo.Location = new System.Drawing.Point(12, 33);
            this.dateDateInfo.Name = "dateDateInfo";
            this.dateDateInfo.Size = new System.Drawing.Size(42, 17);
            this.dateDateInfo.TabIndex = 15;
            this.dateDateInfo.Text = "Date:";
            // 
            // timePanel
            // 
            this.timePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timePanel.Controls.Add(this.timeInfo);
            this.timePanel.Controls.Add(this.timeDateInfo);
            this.timePanel.Controls.Add(this.timePicker);
            this.timePanel.Controls.Add(this.dateTimeButton);
            this.timePanel.Controls.Add(this.timeDatePicker);
            this.timePanel.Location = new System.Drawing.Point(8, 194);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(180, 160);
            this.timePanel.TabIndex = 18;
            // 
            // timeInfo
            // 
            this.timeInfo.AutoSize = true;
            this.timeInfo.Location = new System.Drawing.Point(13, 67);
            this.timeInfo.Name = "timeInfo";
            this.timeInfo.Size = new System.Drawing.Size(43, 17);
            this.timeInfo.TabIndex = 23;
            this.timeInfo.Text = "Time:";
            // 
            // timeDateInfo
            // 
            this.timeDateInfo.AutoSize = true;
            this.timeDateInfo.Location = new System.Drawing.Point(13, 28);
            this.timeDateInfo.Name = "timeDateInfo";
            this.timeDateInfo.Size = new System.Drawing.Size(42, 17);
            this.timeDateInfo.TabIndex = 17;
            this.timeDateInfo.Text = "Date:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(63, 65);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(100, 22);
            this.timePicker.TabIndex = 22;
            this.timePicker.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // dateTimeButton
            // 
            this.dateTimeButton.Location = new System.Drawing.Point(15, 106);
            this.dateTimeButton.Name = "dateTimeButton";
            this.dateTimeButton.Size = new System.Drawing.Size(150, 40);
            this.dateTimeButton.TabIndex = 15;
            this.dateTimeButton.Text = "Search";
            this.dateTimeButton.UseVisualStyleBackColor = true;
            this.dateTimeButton.Click += new System.EventHandler(this.dateTimeButton_Click);
            // 
            // timeDatePicker
            // 
            this.timeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDatePicker.Location = new System.Drawing.Point(63, 25);
            this.timeDatePicker.Name = "timeDatePicker";
            this.timeDatePicker.Size = new System.Drawing.Size(100, 22);
            this.timeDatePicker.TabIndex = 16;
            this.timeDatePicker.ValueChanged += new System.EventHandler(this.timeDatePicker_ValueChanged);
            // 
            // dateTimeHeader
            // 
            this.dateTimeHeader.AutoSize = true;
            this.dateTimeHeader.Location = new System.Drawing.Point(18, 185);
            this.dateTimeHeader.Name = "dateTimeHeader";
            this.dateTimeHeader.Size = new System.Drawing.Size(96, 17);
            this.dateTimeHeader.TabIndex = 19;
            this.dateTimeHeader.Text = "Date and time";
            // 
            // searchPanel
            // 
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.secPanel);
            this.searchPanel.Controls.Add(this.restButton);
            this.searchPanel.Controls.Add(this.dateHeader);
            this.searchPanel.Controls.Add(this.datePanel);
            this.searchPanel.Controls.Add(this.dateTimeHeader);
            this.searchPanel.Controls.Add(this.timePanel);
            this.searchPanel.Location = new System.Drawing.Point(568, 31);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(200, 650);
            this.searchPanel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date, time and second";
            // 
            // secPanel
            // 
            this.secPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secPanel.Controls.Add(this.secInfo);
            this.secPanel.Controls.Add(this.secDateInfo);
            this.secPanel.Controls.Add(this.secDatePicker);
            this.secPanel.Controls.Add(this.secPicker);
            this.secPanel.Controls.Add(this.secTimeInfo);
            this.secPanel.Controls.Add(this.dateTimeSecButton);
            this.secPanel.Controls.Add(this.secTimePicker);
            this.secPanel.Location = new System.Drawing.Point(8, 385);
            this.secPanel.Name = "secPanel";
            this.secPanel.Size = new System.Drawing.Size(180, 180);
            this.secPanel.TabIndex = 22;
            // 
            // secInfo
            // 
            this.secInfo.AutoSize = true;
            this.secInfo.Location = new System.Drawing.Point(12, 92);
            this.secInfo.Name = "secInfo";
            this.secInfo.Size = new System.Drawing.Size(36, 17);
            this.secInfo.TabIndex = 21;
            this.secInfo.Text = "Sec:";
            // 
            // secDateInfo
            // 
            this.secDateInfo.AutoSize = true;
            this.secDateInfo.Location = new System.Drawing.Point(13, 23);
            this.secDateInfo.Name = "secDateInfo";
            this.secDateInfo.Size = new System.Drawing.Size(42, 17);
            this.secDateInfo.TabIndex = 20;
            this.secDateInfo.Text = "Date:";
            // 
            // secDatePicker
            // 
            this.secDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.secDatePicker.Location = new System.Drawing.Point(63, 20);
            this.secDatePicker.Name = "secDatePicker";
            this.secDatePicker.Size = new System.Drawing.Size(100, 22);
            this.secDatePicker.TabIndex = 19;
            this.secDatePicker.ValueChanged += new System.EventHandler(this.secDatePicker_ValueChanged);
            // 
            // secPicker
            // 
            this.secPicker.CustomFormat = "ss";
            this.secPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.secPicker.Location = new System.Drawing.Point(63, 90);
            this.secPicker.Name = "secPicker";
            this.secPicker.ShowUpDown = true;
            this.secPicker.Size = new System.Drawing.Size(100, 22);
            this.secPicker.TabIndex = 18;
            this.secPicker.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
            // 
            // secTimeInfo
            // 
            this.secTimeInfo.AutoSize = true;
            this.secTimeInfo.Location = new System.Drawing.Point(10, 57);
            this.secTimeInfo.Name = "secTimeInfo";
            this.secTimeInfo.Size = new System.Drawing.Size(43, 17);
            this.secTimeInfo.TabIndex = 17;
            this.secTimeInfo.Text = "Time:";
            // 
            // dateTimeSecButton
            // 
            this.dateTimeSecButton.Location = new System.Drawing.Point(13, 125);
            this.dateTimeSecButton.Name = "dateTimeSecButton";
            this.dateTimeSecButton.Size = new System.Drawing.Size(150, 40);
            this.dateTimeSecButton.TabIndex = 15;
            this.dateTimeSecButton.Text = "Search";
            this.dateTimeSecButton.UseVisualStyleBackColor = true;
            this.dateTimeSecButton.Click += new System.EventHandler(this.dateTimeSecButton_Click);
            // 
            // secTimePicker
            // 
            this.secTimePicker.CustomFormat = "HH:mm";
            this.secTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.secTimePicker.Location = new System.Drawing.Point(62, 55);
            this.secTimePicker.Name = "secTimePicker";
            this.secTimePicker.ShowUpDown = true;
            this.secTimePicker.Size = new System.Drawing.Size(100, 22);
            this.secTimePicker.TabIndex = 11;
            this.secTimePicker.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
            this.secTimePicker.ValueChanged += new System.EventHandler(this.secTimePicker_ValueChanged);
            // 
            // restButton
            // 
            this.restButton.Location = new System.Drawing.Point(8, 585);
            this.restButton.Name = "restButton";
            this.restButton.Size = new System.Drawing.Size(180, 50);
            this.restButton.TabIndex = 21;
            this.restButton.Text = "Rest search";
            this.restButton.UseVisualStyleBackColor = true;
            this.restButton.Click += new System.EventHandler(this.restButton_Click);
            // 
            // dateHeader
            // 
            this.dateHeader.AutoSize = true;
            this.dateHeader.Location = new System.Drawing.Point(18, 16);
            this.dateHeader.Name = "dateHeader";
            this.dateHeader.Size = new System.Drawing.Size(38, 17);
            this.dateHeader.TabIndex = 18;
            this.dateHeader.Text = "Date";
            // 
            // searchHeader
            // 
            this.searchHeader.AutoSize = true;
            this.searchHeader.Location = new System.Drawing.Point(586, 22);
            this.searchHeader.Name = "searchHeader";
            this.searchHeader.Size = new System.Drawing.Size(53, 17);
            this.searchHeader.TabIndex = 19;
            this.searchHeader.Text = "Search";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolder});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(782, 28);
            this.menuStrip.TabIndex = 21;
            this.menuStrip.Text = "menuStrip1";
            // 
            // openFolder
            // 
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(103, 24);
            this.openFolder.Text = "Open Folder";
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // imageCount
            // 
            this.imageCount.AutoSize = true;
            this.imageCount.BackColor = System.Drawing.Color.White;
            this.imageCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageCount.Location = new System.Drawing.Point(250, 37);
            this.imageCount.Name = "imageCount";
            this.imageCount.Size = new System.Drawing.Size(0, 17);
            this.imageCount.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 693);
            this.Controls.Add(this.imageCount);
            this.Controls.Add(this.searchHeader);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Image Displayer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.secPanel.ResumeLayout(false);
            this.secPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button dateButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Button dateTimeButton;
        private System.Windows.Forms.Label dateTimeHeader;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label dateHeader;
        private System.Windows.Forms.Label searchHeader;
        private System.Windows.Forms.Button restButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel secPanel;
        private System.Windows.Forms.Button dateTimeSecButton;
        private System.Windows.Forms.DateTimePicker secTimePicker;
        private System.Windows.Forms.Label dateDateInfo;
        private System.Windows.Forms.Label timeInfo;
        private System.Windows.Forms.Label timeDateInfo;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker timeDatePicker;
        private System.Windows.Forms.Label secInfo;
        private System.Windows.Forms.Label secDateInfo;
        private System.Windows.Forms.DateTimePicker secDatePicker;
        private System.Windows.Forms.DateTimePicker secPicker;
        private System.Windows.Forms.Label secTimeInfo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openFolder;
        private System.Windows.Forms.Label imageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSecond;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

