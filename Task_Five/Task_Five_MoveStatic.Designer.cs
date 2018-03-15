namespace Task_Five
{
    partial class Task_Five_MoveStatik
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
            this.btnMoveStatic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoveStatic
            // 
            this.btnMoveStatic.Location = new System.Drawing.Point(288, 137);
            this.btnMoveStatic.Name = "btnMoveStatic";
            this.btnMoveStatic.Size = new System.Drawing.Size(75, 64);
            this.btnMoveStatic.TabIndex = 0;
            this.btnMoveStatic.UseVisualStyleBackColor = true;
            // 
            // Task_Five_MoveStatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 347);
            this.Controls.Add(this.btnMoveStatic);
            this.Name = "Task_Five_MoveStatik";
            this.Text = "Task_Five";
            this.Load += new System.EventHandler(this.Task_Five_MoveStatik_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Task_Five_MoveStatik_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoveStatic;
    }
}

