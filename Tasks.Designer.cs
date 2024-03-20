namespace WinFormsApp1
{
    partial class Tasks
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
            splitContainer1 = new SplitContainer();
            datetime_start = new DateTimePicker();
            SaveTask = new Button();
            datetime_end = new DateTimePicker();
            NewTaskStatus = new ComboBox();
            NewTaskName = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(datetime_start);
            splitContainer1.Panel1.Controls.Add(SaveTask);
            splitContainer1.Panel1.Controls.Add(datetime_end);
            splitContainer1.Panel1.Controls.Add(NewTaskStatus);
            splitContainer1.Panel1.Controls.Add(NewTaskName);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 0;
            // 
            // datetime_start
            // 
            datetime_start.Location = new Point(14, 70);
            datetime_start.Name = "datetime_start";
            datetime_start.Size = new Size(231, 23);
            datetime_start.TabIndex = 3;
            // 
            // SaveTask
            // 
            SaveTask.Location = new Point(15, 128);
            SaveTask.Name = "SaveTask";
            SaveTask.Size = new Size(230, 23);
            SaveTask.TabIndex = 5;
            SaveTask.Text = "button1";
            SaveTask.UseVisualStyleBackColor = true;
            SaveTask.Click += SaveTask_Click;
            // 
            // datetime_end
            // 
            datetime_end.Location = new Point(15, 99);
            datetime_end.Name = "datetime_end";
            datetime_end.Size = new Size(231, 23);
            datetime_end.TabIndex = 4;
            // 
            // NewTaskStatus
            // 
            NewTaskStatus.FormattingEnabled = true;
            NewTaskStatus.Items.AddRange(new object[] { "Новая", "В работе ", "Завершено" });
            NewTaskStatus.Location = new Point(14, 41);
            NewTaskStatus.Name = "NewTaskStatus";
            NewTaskStatus.Size = new Size(231, 23);
            NewTaskStatus.TabIndex = 2;
            // 
            // NewTaskName
            // 
            NewTaskName.Location = new Point(14, 12);
            NewTaskName.Name = "NewTaskName";
            NewTaskName.Size = new Size(232, 23);
            NewTaskName.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(536, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Tasks";
            Text = "Form2";
            FormClosing += Task_FromClosing;
            Load += Tasks_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox NewTaskName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SaveTask;
        private DateTimePicker datetime_end;
        private DateTimePicker datetime_start;
        private ComboBox NewTaskStatus;
    }
}