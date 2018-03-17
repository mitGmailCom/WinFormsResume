namespace Task_Eight
{
    partial class TaskEightBestOil
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
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbSumClientFuel = new System.Windows.Forms.Label();
            this.lbLFuel = new System.Windows.Forms.Label();
            this.tbSumClientInput = new System.Windows.Forms.TextBox();
            this.tbLFuel = new System.Windows.Forms.TextBox();
            this.lbGrnPriceFuel = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbFuel = new System.Windows.Forms.Label();
            this.cbTypeFuel = new System.Windows.Forms.ComboBox();
            this.gbChoiseType = new System.Windows.Forms.GroupBox();
            this.rbTypeSum = new System.Windows.Forms.RadioButton();
            this.rbCountFuel = new System.Windows.Forms.RadioButton();
            this.gbToPayFuel = new System.Windows.Forms.GroupBox();
            this.lbGrnToPayFuel = new System.Windows.Forms.Label();
            this.SumFuelShow = new System.Windows.Forms.Label();
            this.gbCafe = new System.Windows.Forms.GroupBox();
            this.lbCountCafe = new System.Windows.Forms.Label();
            this.lbPriceCafe = new System.Windows.Forms.Label();
            this.cbCola = new System.Windows.Forms.CheckBox();
            this.cbPotatoFri = new System.Windows.Forms.CheckBox();
            this.cbHamburger = new System.Windows.Forms.CheckBox();
            this.cbHotDog = new System.Windows.Forms.CheckBox();
            this.tbCountCola = new System.Windows.Forms.TextBox();
            this.tbPriceHamburger = new System.Windows.Forms.TextBox();
            this.tbPricePotatoFri = new System.Windows.Forms.TextBox();
            this.tbPriceCola = new System.Windows.Forms.TextBox();
            this.tbCountHotDog = new System.Windows.Forms.TextBox();
            this.tbPriceHotDog = new System.Windows.Forms.TextBox();
            this.tbCountPotatoFri = new System.Windows.Forms.TextBox();
            this.tbCountHamburger = new System.Windows.Forms.TextBox();
            this.gbToPayCafe = new System.Windows.Forms.GroupBox();
            this.lbGrnToPayCafe = new System.Windows.Forms.Label();
            this.lbSumCafeShow = new System.Windows.Forms.Label();
            this.gbSum = new System.Windows.Forms.GroupBox();
            this.lbTotalSumShow = new System.Windows.Forms.Label();
            this.lbGrnTotalSumShow = new System.Windows.Forms.Label();
            this.lbTotalSum = new System.Windows.Forms.Label();
            this.lbOutSum = new System.Windows.Forms.Label();
            this.lbInSum = new System.Windows.Forms.Label();
            this.lbGrnOutSum = new System.Windows.Forms.Label();
            this.lbGrnInSum = new System.Windows.Forms.Label();
            this.tbInSum = new System.Windows.Forms.TextBox();
            this.lbOutSumShow = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbFuel.SuspendLayout();
            this.gbChoiseType.SuspendLayout();
            this.gbToPayFuel.SuspendLayout();
            this.gbCafe.SuspendLayout();
            this.gbToPayCafe.SuspendLayout();
            this.gbSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.tbPrice);
            this.gbFuel.Controls.Add(this.lbSumClientFuel);
            this.gbFuel.Controls.Add(this.lbLFuel);
            this.gbFuel.Controls.Add(this.tbSumClientInput);
            this.gbFuel.Controls.Add(this.tbLFuel);
            this.gbFuel.Controls.Add(this.lbGrnPriceFuel);
            this.gbFuel.Controls.Add(this.lbPrice);
            this.gbFuel.Controls.Add(this.lbFuel);
            this.gbFuel.Controls.Add(this.cbTypeFuel);
            this.gbFuel.Controls.Add(this.gbChoiseType);
            this.gbFuel.Controls.Add(this.gbToPayFuel);
            this.gbFuel.Location = new System.Drawing.Point(12, 7);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(236, 249);
            this.gbFuel.TabIndex = 0;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Автозаправка";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(130, 59);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(63, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // lbSumClientFuel
            // 
            this.lbSumClientFuel.AutoSize = true;
            this.lbSumClientFuel.Location = new System.Drawing.Point(199, 138);
            this.lbSumClientFuel.Name = "lbSumClientFuel";
            this.lbSumClientFuel.Size = new System.Drawing.Size(27, 13);
            this.lbSumClientFuel.TabIndex = 12;
            this.lbSumClientFuel.Text = "грн.";
            // 
            // lbLFuel
            // 
            this.lbLFuel.AutoSize = true;
            this.lbLFuel.Location = new System.Drawing.Point(199, 103);
            this.lbLFuel.Name = "lbLFuel";
            this.lbLFuel.Size = new System.Drawing.Size(16, 13);
            this.lbLFuel.TabIndex = 11;
            this.lbLFuel.Text = "л.";
            // 
            // tbSumClientInput
            // 
            this.tbSumClientInput.Location = new System.Drawing.Point(130, 134);
            this.tbSumClientInput.Name = "tbSumClientInput";
            this.tbSumClientInput.Size = new System.Drawing.Size(63, 20);
            this.tbSumClientInput.TabIndex = 10;
            // 
            // tbLFuel
            // 
            this.tbLFuel.Location = new System.Drawing.Point(130, 99);
            this.tbLFuel.Name = "tbLFuel";
            this.tbLFuel.Size = new System.Drawing.Size(63, 20);
            this.tbLFuel.TabIndex = 9;
            // 
            // lbGrnPriceFuel
            // 
            this.lbGrnPriceFuel.AutoSize = true;
            this.lbGrnPriceFuel.Location = new System.Drawing.Point(199, 62);
            this.lbGrnPriceFuel.Name = "lbGrnPriceFuel";
            this.lbGrnPriceFuel.Size = new System.Drawing.Size(27, 13);
            this.lbGrnPriceFuel.TabIndex = 8;
            this.lbGrnPriceFuel.Text = "грн.";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(43, 57);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 13);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Цена";
            // 
            // lbFuel
            // 
            this.lbFuel.AutoSize = true;
            this.lbFuel.Location = new System.Drawing.Point(43, 22);
            this.lbFuel.Name = "lbFuel";
            this.lbFuel.Size = new System.Drawing.Size(44, 13);
            this.lbFuel.TabIndex = 6;
            this.lbFuel.Text = "Бензин";
            // 
            // cbTypeFuel
            // 
            this.cbTypeFuel.FormattingEnabled = true;
            this.cbTypeFuel.Location = new System.Drawing.Point(130, 19);
            this.cbTypeFuel.Name = "cbTypeFuel";
            this.cbTypeFuel.Size = new System.Drawing.Size(100, 21);
            this.cbTypeFuel.TabIndex = 5;
            // 
            // gbChoiseType
            // 
            this.gbChoiseType.Controls.Add(this.rbTypeSum);
            this.gbChoiseType.Controls.Add(this.rbCountFuel);
            this.gbChoiseType.Location = new System.Drawing.Point(6, 83);
            this.gbChoiseType.Name = "gbChoiseType";
            this.gbChoiseType.Size = new System.Drawing.Size(118, 83);
            this.gbChoiseType.TabIndex = 4;
            this.gbChoiseType.TabStop = false;
            // 
            // rbTypeSum
            // 
            this.rbTypeSum.AutoSize = true;
            this.rbTypeSum.Location = new System.Drawing.Point(12, 54);
            this.rbTypeSum.Name = "rbTypeSum";
            this.rbTypeSum.Size = new System.Drawing.Size(59, 17);
            this.rbTypeSum.TabIndex = 1;
            this.rbTypeSum.TabStop = true;
            this.rbTypeSum.Text = "Сумма";
            this.rbTypeSum.UseVisualStyleBackColor = true;
            // 
            // rbCountFuel
            // 
            this.rbCountFuel.AutoSize = true;
            this.rbCountFuel.Location = new System.Drawing.Point(12, 19);
            this.rbCountFuel.Name = "rbCountFuel";
            this.rbCountFuel.Size = new System.Drawing.Size(84, 17);
            this.rbCountFuel.TabIndex = 0;
            this.rbCountFuel.TabStop = true;
            this.rbCountFuel.Text = "Количество";
            this.rbCountFuel.UseVisualStyleBackColor = true;
            // 
            // gbToPayFuel
            // 
            this.gbToPayFuel.Controls.Add(this.lbGrnToPayFuel);
            this.gbToPayFuel.Controls.Add(this.SumFuelShow);
            this.gbToPayFuel.Location = new System.Drawing.Point(6, 172);
            this.gbToPayFuel.Name = "gbToPayFuel";
            this.gbToPayFuel.Size = new System.Drawing.Size(207, 71);
            this.gbToPayFuel.TabIndex = 3;
            this.gbToPayFuel.TabStop = false;
            this.gbToPayFuel.Text = "К оплате:";
            // 
            // lbGrnToPayFuel
            // 
            this.lbGrnToPayFuel.AutoSize = true;
            this.lbGrnToPayFuel.Location = new System.Drawing.Point(148, 38);
            this.lbGrnToPayFuel.Name = "lbGrnToPayFuel";
            this.lbGrnToPayFuel.Size = new System.Drawing.Size(27, 13);
            this.lbGrnToPayFuel.TabIndex = 8;
            this.lbGrnToPayFuel.Text = "грн.";
            // 
            // SumFuelShow
            // 
            this.SumFuelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumFuelShow.Location = new System.Drawing.Point(85, 16);
            this.SumFuelShow.Name = "SumFuelShow";
            this.SumFuelShow.Size = new System.Drawing.Size(57, 52);
            this.SumFuelShow.TabIndex = 7;
            this.SumFuelShow.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbCafe
            // 
            this.gbCafe.Controls.Add(this.lbCountCafe);
            this.gbCafe.Controls.Add(this.lbPriceCafe);
            this.gbCafe.Controls.Add(this.cbCola);
            this.gbCafe.Controls.Add(this.cbPotatoFri);
            this.gbCafe.Controls.Add(this.cbHamburger);
            this.gbCafe.Controls.Add(this.cbHotDog);
            this.gbCafe.Controls.Add(this.tbCountCola);
            this.gbCafe.Controls.Add(this.tbPriceHamburger);
            this.gbCafe.Controls.Add(this.tbPricePotatoFri);
            this.gbCafe.Controls.Add(this.tbPriceCola);
            this.gbCafe.Controls.Add(this.tbCountHotDog);
            this.gbCafe.Controls.Add(this.tbPriceHotDog);
            this.gbCafe.Controls.Add(this.tbCountPotatoFri);
            this.gbCafe.Controls.Add(this.tbCountHamburger);
            this.gbCafe.Controls.Add(this.gbToPayCafe);
            this.gbCafe.Location = new System.Drawing.Point(264, 7);
            this.gbCafe.Name = "gbCafe";
            this.gbCafe.Size = new System.Drawing.Size(231, 249);
            this.gbCafe.TabIndex = 1;
            this.gbCafe.TabStop = false;
            this.gbCafe.Text = "Мини-кафе";
            // 
            // lbCountCafe
            // 
            this.lbCountCafe.AutoSize = true;
            this.lbCountCafe.Location = new System.Drawing.Point(175, 16);
            this.lbCountCafe.Name = "lbCountCafe";
            this.lbCountCafe.Size = new System.Drawing.Size(41, 13);
            this.lbCountCafe.TabIndex = 23;
            this.lbCountCafe.Text = "Кол-во";
            // 
            // lbPriceCafe
            // 
            this.lbPriceCafe.AutoSize = true;
            this.lbPriceCafe.Location = new System.Drawing.Point(139, 16);
            this.lbPriceCafe.Name = "lbPriceCafe";
            this.lbPriceCafe.Size = new System.Drawing.Size(33, 13);
            this.lbPriceCafe.TabIndex = 22;
            this.lbPriceCafe.Text = "Цена";
            // 
            // cbCola
            // 
            this.cbCola.AutoSize = true;
            this.cbCola.Location = new System.Drawing.Point(16, 140);
            this.cbCola.Name = "cbCola";
            this.cbCola.Size = new System.Drawing.Size(78, 17);
            this.cbCola.TabIndex = 21;
            this.cbCola.Text = "Кока-кола";
            this.cbCola.UseVisualStyleBackColor = true;
            // 
            // cbPotatoFri
            // 
            this.cbPotatoFri.AutoSize = true;
            this.cbPotatoFri.Location = new System.Drawing.Point(16, 106);
            this.cbPotatoFri.Name = "cbPotatoFri";
            this.cbPotatoFri.Size = new System.Drawing.Size(99, 17);
            this.cbPotatoFri.TabIndex = 20;
            this.cbPotatoFri.Text = "Картошка-фри";
            this.cbPotatoFri.UseVisualStyleBackColor = true;
            // 
            // cbHamburger
            // 
            this.cbHamburger.AutoSize = true;
            this.cbHamburger.Location = new System.Drawing.Point(16, 72);
            this.cbHamburger.Name = "cbHamburger";
            this.cbHamburger.Size = new System.Drawing.Size(80, 17);
            this.cbHamburger.TabIndex = 19;
            this.cbHamburger.Text = "Гамбургер";
            this.cbHamburger.UseVisualStyleBackColor = true;
            // 
            // cbHotDog
            // 
            this.cbHotDog.AutoSize = true;
            this.cbHotDog.Location = new System.Drawing.Point(16, 40);
            this.cbHotDog.Name = "cbHotDog";
            this.cbHotDog.Size = new System.Drawing.Size(64, 17);
            this.cbHotDog.TabIndex = 18;
            this.cbHotDog.Text = "Хот-дог";
            this.cbHotDog.UseVisualStyleBackColor = true;
            // 
            // tbCountCola
            // 
            this.tbCountCola.Location = new System.Drawing.Point(178, 140);
            this.tbCountCola.Name = "tbCountCola";
            this.tbCountCola.Size = new System.Drawing.Size(42, 20);
            this.tbCountCola.TabIndex = 17;
            // 
            // tbPriceHamburger
            // 
            this.tbPriceHamburger.Location = new System.Drawing.Point(130, 72);
            this.tbPriceHamburger.Name = "tbPriceHamburger";
            this.tbPriceHamburger.Size = new System.Drawing.Size(42, 20);
            this.tbPriceHamburger.TabIndex = 16;
            // 
            // tbPricePotatoFri
            // 
            this.tbPricePotatoFri.Location = new System.Drawing.Point(130, 104);
            this.tbPricePotatoFri.Name = "tbPricePotatoFri";
            this.tbPricePotatoFri.Size = new System.Drawing.Size(42, 20);
            this.tbPricePotatoFri.TabIndex = 15;
            // 
            // tbPriceCola
            // 
            this.tbPriceCola.Location = new System.Drawing.Point(130, 140);
            this.tbPriceCola.Name = "tbPriceCola";
            this.tbPriceCola.Size = new System.Drawing.Size(42, 20);
            this.tbPriceCola.TabIndex = 14;
            // 
            // tbCountHotDog
            // 
            this.tbCountHotDog.Location = new System.Drawing.Point(178, 37);
            this.tbCountHotDog.Name = "tbCountHotDog";
            this.tbCountHotDog.Size = new System.Drawing.Size(42, 20);
            this.tbCountHotDog.TabIndex = 13;
            // 
            // tbPriceHotDog
            // 
            this.tbPriceHotDog.Location = new System.Drawing.Point(130, 37);
            this.tbPriceHotDog.Name = "tbPriceHotDog";
            this.tbPriceHotDog.Size = new System.Drawing.Size(42, 20);
            this.tbPriceHotDog.TabIndex = 12;
            // 
            // tbCountPotatoFri
            // 
            this.tbCountPotatoFri.Location = new System.Drawing.Point(178, 104);
            this.tbCountPotatoFri.Name = "tbCountPotatoFri";
            this.tbCountPotatoFri.Size = new System.Drawing.Size(42, 20);
            this.tbCountPotatoFri.TabIndex = 11;
            // 
            // tbCountHamburger
            // 
            this.tbCountHamburger.Location = new System.Drawing.Point(178, 72);
            this.tbCountHamburger.Name = "tbCountHamburger";
            this.tbCountHamburger.Size = new System.Drawing.Size(42, 20);
            this.tbCountHamburger.TabIndex = 10;
            // 
            // gbToPayCafe
            // 
            this.gbToPayCafe.Controls.Add(this.lbGrnToPayCafe);
            this.gbToPayCafe.Controls.Add(this.lbSumCafeShow);
            this.gbToPayCafe.Location = new System.Drawing.Point(6, 172);
            this.gbToPayCafe.Name = "gbToPayCafe";
            this.gbToPayCafe.Size = new System.Drawing.Size(214, 71);
            this.gbToPayCafe.TabIndex = 3;
            this.gbToPayCafe.TabStop = false;
            this.gbToPayCafe.Text = "К оплате:";
            // 
            // lbGrnToPayCafe
            // 
            this.lbGrnToPayCafe.AutoSize = true;
            this.lbGrnToPayCafe.Location = new System.Drawing.Point(181, 38);
            this.lbGrnToPayCafe.Name = "lbGrnToPayCafe";
            this.lbGrnToPayCafe.Size = new System.Drawing.Size(27, 13);
            this.lbGrnToPayCafe.TabIndex = 13;
            this.lbGrnToPayCafe.Text = "грн.";
            // 
            // lbSumCafeShow
            // 
            this.lbSumCafeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumCafeShow.Location = new System.Drawing.Point(109, 16);
            this.lbSumCafeShow.Name = "lbSumCafeShow";
            this.lbSumCafeShow.Size = new System.Drawing.Size(57, 52);
            this.lbSumCafeShow.TabIndex = 8;
            // 
            // gbSum
            // 
            this.gbSum.Controls.Add(this.lbTotalSumShow);
            this.gbSum.Controls.Add(this.lbGrnTotalSumShow);
            this.gbSum.Controls.Add(this.lbTotalSum);
            this.gbSum.Controls.Add(this.lbOutSum);
            this.gbSum.Controls.Add(this.lbInSum);
            this.gbSum.Controls.Add(this.lbGrnOutSum);
            this.gbSum.Controls.Add(this.lbGrnInSum);
            this.gbSum.Controls.Add(this.tbInSum);
            this.gbSum.Controls.Add(this.lbOutSumShow);
            this.gbSum.Controls.Add(this.btnCalculate);
            this.gbSum.Location = new System.Drawing.Point(18, 262);
            this.gbSum.Name = "gbSum";
            this.gbSum.Size = new System.Drawing.Size(477, 111);
            this.gbSum.TabIndex = 2;
            this.gbSum.TabStop = false;
            this.gbSum.Text = "Взаиморасчет:";
            // 
            // lbTotalSumShow
            // 
            this.lbTotalSumShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalSumShow.Location = new System.Drawing.Point(21, 45);
            this.lbTotalSumShow.Name = "lbTotalSumShow";
            this.lbTotalSumShow.Size = new System.Drawing.Size(50, 43);
            this.lbTotalSumShow.TabIndex = 17;
            // 
            // lbGrnTotalSumShow
            // 
            this.lbGrnTotalSumShow.AutoSize = true;
            this.lbGrnTotalSumShow.Location = new System.Drawing.Point(77, 75);
            this.lbGrnTotalSumShow.Name = "lbGrnTotalSumShow";
            this.lbGrnTotalSumShow.Size = new System.Drawing.Size(27, 13);
            this.lbGrnTotalSumShow.TabIndex = 16;
            this.lbGrnTotalSumShow.Text = "грн.";
            // 
            // lbTotalSum
            // 
            this.lbTotalSum.AutoSize = true;
            this.lbTotalSum.Location = new System.Drawing.Point(22, 19);
            this.lbTotalSum.Name = "lbTotalSum";
            this.lbTotalSum.Size = new System.Drawing.Size(89, 13);
            this.lbTotalSum.TabIndex = 15;
            this.lbTotalSum.Text = "ВСЕГО к оплате";
            // 
            // lbOutSum
            // 
            this.lbOutSum.AutoSize = true;
            this.lbOutSum.Location = new System.Drawing.Point(398, 19);
            this.lbOutSum.Name = "lbOutSum";
            this.lbOutSum.Size = new System.Drawing.Size(37, 13);
            this.lbOutSum.TabIndex = 14;
            this.lbOutSum.Text = "Сдача";
            // 
            // lbInSum
            // 
            this.lbInSum.AutoSize = true;
            this.lbInSum.Location = new System.Drawing.Point(279, 19);
            this.lbInSum.Name = "lbInSum";
            this.lbInSum.Size = new System.Drawing.Size(50, 13);
            this.lbInSum.TabIndex = 13;
            this.lbInSum.Text = "Внесено";
            // 
            // lbGrnOutSum
            // 
            this.lbGrnOutSum.AutoSize = true;
            this.lbGrnOutSum.Location = new System.Drawing.Point(441, 70);
            this.lbGrnOutSum.Name = "lbGrnOutSum";
            this.lbGrnOutSum.Size = new System.Drawing.Size(27, 13);
            this.lbGrnOutSum.TabIndex = 12;
            this.lbGrnOutSum.Text = "грн.";
            // 
            // lbGrnInSum
            // 
            this.lbGrnInSum.AutoSize = true;
            this.lbGrnInSum.Location = new System.Drawing.Point(335, 70);
            this.lbGrnInSum.Name = "lbGrnInSum";
            this.lbGrnInSum.Size = new System.Drawing.Size(27, 13);
            this.lbGrnInSum.TabIndex = 11;
            this.lbGrnInSum.Text = "грн.";
            // 
            // tbInSum
            // 
            this.tbInSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInSum.Location = new System.Drawing.Point(262, 62);
            this.tbInSum.Name = "tbInSum";
            this.tbInSum.Size = new System.Drawing.Size(67, 26);
            this.tbInSum.TabIndex = 10;
            // 
            // lbOutSumShow
            // 
            this.lbOutSumShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOutSumShow.Location = new System.Drawing.Point(385, 45);
            this.lbOutSumShow.Name = "lbOutSumShow";
            this.lbOutSumShow.Size = new System.Drawing.Size(50, 43);
            this.lbOutSumShow.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(151, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 81);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Посчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // TaskEightBestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 374);
            this.Controls.Add(this.gbSum);
            this.Controls.Add(this.gbCafe);
            this.Controls.Add(this.gbFuel);
            this.Name = "TaskEightBestOil";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.TaskEightBestOil_Load);
            this.gbFuel.ResumeLayout(false);
            this.gbFuel.PerformLayout();
            this.gbChoiseType.ResumeLayout(false);
            this.gbChoiseType.PerformLayout();
            this.gbToPayFuel.ResumeLayout(false);
            this.gbToPayFuel.PerformLayout();
            this.gbCafe.ResumeLayout(false);
            this.gbCafe.PerformLayout();
            this.gbToPayCafe.ResumeLayout(false);
            this.gbToPayCafe.PerformLayout();
            this.gbSum.ResumeLayout(false);
            this.gbSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuel;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbSumClientFuel;
        private System.Windows.Forms.Label lbLFuel;
        private System.Windows.Forms.TextBox tbSumClientInput;
        private System.Windows.Forms.TextBox tbLFuel;
        private System.Windows.Forms.Label lbGrnPriceFuel;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbFuel;
        private System.Windows.Forms.ComboBox cbTypeFuel;
        private System.Windows.Forms.GroupBox gbChoiseType;
        private System.Windows.Forms.RadioButton rbTypeSum;
        private System.Windows.Forms.RadioButton rbCountFuel;
        private System.Windows.Forms.GroupBox gbToPayFuel;
        private System.Windows.Forms.Label lbGrnToPayFuel;
        private System.Windows.Forms.Label SumFuelShow;
        private System.Windows.Forms.GroupBox gbCafe;
        private System.Windows.Forms.CheckBox cbCola;
        private System.Windows.Forms.CheckBox cbPotatoFri;
        private System.Windows.Forms.CheckBox cbHamburger;
        private System.Windows.Forms.CheckBox cbHotDog;
        private System.Windows.Forms.TextBox tbCountCola;
        private System.Windows.Forms.TextBox tbPriceHamburger;
        private System.Windows.Forms.TextBox tbPricePotatoFri;
        private System.Windows.Forms.TextBox tbPriceCola;
        private System.Windows.Forms.TextBox tbCountHotDog;
        private System.Windows.Forms.TextBox tbPriceHotDog;
        private System.Windows.Forms.TextBox tbCountPotatoFri;
        private System.Windows.Forms.TextBox tbCountHamburger;
        private System.Windows.Forms.GroupBox gbToPayCafe;
        private System.Windows.Forms.GroupBox gbSum;
        private System.Windows.Forms.TextBox tbInSum;
        private System.Windows.Forms.Label lbOutSumShow;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbSumCafeShow;
        private System.Windows.Forms.Label lbCountCafe;
        private System.Windows.Forms.Label lbPriceCafe;
        private System.Windows.Forms.Label lbGrnToPayCafe;
        private System.Windows.Forms.Label lbTotalSumShow;
        private System.Windows.Forms.Label lbGrnTotalSumShow;
        private System.Windows.Forms.Label lbTotalSum;
        private System.Windows.Forms.Label lbOutSum;
        private System.Windows.Forms.Label lbInSum;
        private System.Windows.Forms.Label lbGrnOutSum;
        private System.Windows.Forms.Label lbGrnInSum;
    }
}

