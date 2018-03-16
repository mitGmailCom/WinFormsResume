namespace Task_Seven
{
    partial class HowTimeTo
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
            this.lbInputDate = new System.Windows.Forms.Label();
            this.gbCaseOutput = new System.Windows.Forms.GroupBox();
            this.rbYears = new System.Windows.Forms.RadioButton();
            this.rbMonthes = new System.Windows.Forms.RadioButton();
            this.rbDays = new System.Windows.Forms.RadioButton();
            this.rbMinute = new System.Windows.Forms.RadioButton();
            this.rbSec = new System.Windows.Forms.RadioButton();
            this.lbCaseOutput = new System.Windows.Forms.Label();
            this.lbOutputShow = new System.Windows.Forms.Label();
            this.mtbInputDate = new System.Windows.Forms.MaskedTextBox();
            this.lbMaketForInput = new System.Windows.Forms.Label();
            this.gbCaseOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInputDate
            // 
            this.lbInputDate.AutoSize = true;
            this.lbInputDate.Font = new System.Drawing.Font("Calibri", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInputDate.Location = new System.Drawing.Point(255, 27);
            this.lbInputDate.Name = "lbInputDate";
            this.lbInputDate.Size = new System.Drawing.Size(87, 17);
            this.lbInputDate.TabIndex = 1;
            this.lbInputDate.Text = "Введите дату";
            // 
            // gbCaseOutput
            // 
            this.gbCaseOutput.Controls.Add(this.rbSec);
            this.gbCaseOutput.Controls.Add(this.rbMinute);
            this.gbCaseOutput.Controls.Add(this.rbDays);
            this.gbCaseOutput.Controls.Add(this.rbMonthes);
            this.gbCaseOutput.Controls.Add(this.rbYears);
            this.gbCaseOutput.Location = new System.Drawing.Point(31, 62);
            this.gbCaseOutput.Name = "gbCaseOutput";
            this.gbCaseOutput.Size = new System.Drawing.Size(153, 142);
            this.gbCaseOutput.TabIndex = 2;
            this.gbCaseOutput.TabStop = false;
            // 
            // rbYears
            // 
            this.rbYears.AutoSize = true;
            this.rbYears.Location = new System.Drawing.Point(18, 19);
            this.rbYears.Name = "rbYears";
            this.rbYears.Size = new System.Drawing.Size(49, 17);
            this.rbYears.TabIndex = 0;
            this.rbYears.Text = "Года";
            this.rbYears.UseVisualStyleBackColor = true;
            this.rbYears.CheckedChanged += new System.EventHandler(this.rbYears_CheckedChanged);
            // 
            // rbMonthes
            // 
            this.rbMonthes.AutoSize = true;
            this.rbMonthes.Location = new System.Drawing.Point(18, 42);
            this.rbMonthes.Name = "rbMonthes";
            this.rbMonthes.Size = new System.Drawing.Size(66, 17);
            this.rbMonthes.TabIndex = 1;
            this.rbMonthes.Text = "Месяцы";
            this.rbMonthes.UseVisualStyleBackColor = true;
            // 
            // rbDays
            // 
            this.rbDays.AutoSize = true;
            this.rbDays.Location = new System.Drawing.Point(18, 65);
            this.rbDays.Name = "rbDays";
            this.rbDays.Size = new System.Drawing.Size(46, 17);
            this.rbDays.TabIndex = 2;
            this.rbDays.Text = "Дни";
            this.rbDays.UseVisualStyleBackColor = true;
            // 
            // rbMinute
            // 
            this.rbMinute.AutoSize = true;
            this.rbMinute.Location = new System.Drawing.Point(18, 88);
            this.rbMinute.Name = "rbMinute";
            this.rbMinute.Size = new System.Drawing.Size(64, 17);
            this.rbMinute.TabIndex = 3;
            this.rbMinute.Text = "Минуты";
            this.rbMinute.UseVisualStyleBackColor = true;
            // 
            // rbSec
            // 
            this.rbSec.AutoSize = true;
            this.rbSec.Location = new System.Drawing.Point(18, 109);
            this.rbSec.Name = "rbSec";
            this.rbSec.Size = new System.Drawing.Size(69, 17);
            this.rbSec.TabIndex = 4;
            this.rbSec.Text = "Секунды";
            this.rbSec.UseVisualStyleBackColor = true;
            // 
            // lbCaseOutput
            // 
            this.lbCaseOutput.AutoSize = true;
            this.lbCaseOutput.Font = new System.Drawing.Font("Calibri", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCaseOutput.Location = new System.Drawing.Point(12, 27);
            this.lbCaseOutput.Name = "lbCaseOutput";
            this.lbCaseOutput.Size = new System.Drawing.Size(199, 17);
            this.lbCaseOutput.TabIndex = 3;
            this.lbCaseOutput.Text = "Выберите вариант отображения";
            // 
            // lbOutputShow
            // 
            this.lbOutputShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOutputShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOutputShow.Location = new System.Drawing.Point(204, 144);
            this.lbOutputShow.Name = "lbOutputShow";
            this.lbOutputShow.Size = new System.Drawing.Size(188, 34);
            this.lbOutputShow.TabIndex = 4;
            this.lbOutputShow.Text = "Output";
            this.lbOutputShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbInputDate
            // 
            this.mtbInputDate.Location = new System.Drawing.Point(248, 94);
            this.mtbInputDate.Mask = "00/00/0000 90:00";
            this.mtbInputDate.Name = "mtbInputDate";
            this.mtbInputDate.Size = new System.Drawing.Size(100, 20);
            this.mtbInputDate.TabIndex = 5;
            this.mtbInputDate.ValidatingType = typeof(System.DateTime);
            this.mtbInputDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbInputDate_MaskInputRejected);
            this.mtbInputDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbInputDate_KeyPress);
            // 
            // lbMaketForInput
            // 
            this.lbMaketForInput.AutoSize = true;
            this.lbMaketForInput.Location = new System.Drawing.Point(245, 78);
            this.lbMaketForInput.Name = "lbMaketForInput";
            this.lbMaketForInput.Size = new System.Drawing.Size(93, 13);
            this.lbMaketForInput.TabIndex = 6;
            this.lbMaketForInput.Text = "дд.мм.гггг чч:мм";
            // 
            // HowTimeTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 253);
            this.Controls.Add(this.lbMaketForInput);
            this.Controls.Add(this.mtbInputDate);
            this.Controls.Add(this.lbOutputShow);
            this.Controls.Add(this.lbCaseOutput);
            this.Controls.Add(this.gbCaseOutput);
            this.Controls.Add(this.lbInputDate);
            this.Name = "HowTimeTo";
            this.Text = "TimeTo";
            this.gbCaseOutput.ResumeLayout(false);
            this.gbCaseOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInputDate;
        private System.Windows.Forms.GroupBox gbCaseOutput;
        private System.Windows.Forms.RadioButton rbSec;
        private System.Windows.Forms.RadioButton rbMinute;
        private System.Windows.Forms.RadioButton rbDays;
        private System.Windows.Forms.RadioButton rbMonthes;
        private System.Windows.Forms.RadioButton rbYears;
        private System.Windows.Forms.Label lbCaseOutput;
        private System.Windows.Forms.Label lbOutputShow;
        private System.Windows.Forms.MaskedTextBox mtbInputDate;
        private System.Windows.Forms.Label lbMaketForInput;
    }
}

