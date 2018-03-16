namespace Task_Six
{
    partial class TaskSix
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpTaskSix = new System.Windows.Forms.DateTimePicker();
            this.tbTaskSix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpTaskSix
            // 
            this.dtpTaskSix.Location = new System.Drawing.Point(121, 94);
            this.dtpTaskSix.Name = "dtpTaskSix";
            this.dtpTaskSix.Size = new System.Drawing.Size(200, 20);
            this.dtpTaskSix.TabIndex = 0;
            this.dtpTaskSix.ValueChanged += new System.EventHandler(this.dtpTaskSix_ValueChanged);
            // 
            // tbTaskSix
            // 
            this.tbTaskSix.Location = new System.Drawing.Point(71, 36);
            this.tbTaskSix.Name = "tbTaskSix";
            this.tbTaskSix.ReadOnly = true;
            this.tbTaskSix.Size = new System.Drawing.Size(306, 20);
            this.tbTaskSix.TabIndex = 1;
            // 
            // TaskSix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 261);
            this.Controls.Add(this.tbTaskSix);
            this.Controls.Add(this.dtpTaskSix);
            this.Name = "TaskSix";
            this.Text = "DateToTextBox";
            this.Load += new System.EventHandler(this.TaskSix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTaskSix;
        private System.Windows.Forms.TextBox tbTaskSix;
    }
}

