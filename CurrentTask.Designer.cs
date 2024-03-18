namespace WinFormsApp1
{
    partial class CurrentTask
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            taskName = new Label();
            SuspendLayout();
            // 
            // taskName
            // 
            taskName.AutoSize = true;
            taskName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            taskName.Location = new Point(89, 24);
            taskName.Name = "taskName";
            taskName.Size = new Size(119, 20);
            taskName.TabIndex = 0;
            taskName.Text = "Название задачи";
            // 
            // CurrentTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(taskName);
            Name = "CurrentTask";
            Size = new Size(318, 102);
            Click += CurrentTask_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskName;
    }
}
