using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Написать программу, вычисляющую сколько осталось времени до указанной даты(дата вводится с клавиатуры в Edit). Предусмотреть возможность 
//выдачи результата в годах, месяцах, днях, минутах, секундах (для первых двух вариантов ответ дробный). Для переключения между вариантами
//желательно использовать переключатели (RadioButton).

namespace Task_Seven
{
    public partial class HowTimeTo : Form
    {
        private int deltaMonth{ get; set; }
        public HowTimeTo()
        {
            InitializeComponent();
        }

        private void mtbInputDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Неверный формат ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int ReturnMonth()
        {
            try
            {
                deltaMonth = 0;
                this.lbOutputShow.Text = "null";
                DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
                DateTime nowDate = new DateTime();
                nowDate = DateTime.Now;
                int nowYear = nowDate.Year;
                int targetYear = inputDate.Year;
                
                for (int i = nowYear; i <= targetYear; i++)
                {
                    if (nowYear == targetYear)
                        deltaMonth = inputDate.Month - nowDate.Month;
                    if (nowYear != targetYear)
                    {
                        if (i == nowYear & nowYear != targetYear)
                            deltaMonth += 12 - nowDate.Month;
                        else if (i == targetYear & nowYear != targetYear)
                            deltaMonth += inputDate.Month;
                        else
                            deltaMonth += 12;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show($"Неправильный формат ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return deltaMonth;
        }

        private void CheckedYearsShow()
        {
            if (this.rbYears.Checked)
            {
                this.lbOutputShow.Text = "null";
                int temp = ReturnMonth();
                int integer = temp / 12;
                int ostatok = temp % 12;
                this.lbOutputShow.Text = $"{(integer + Math.Round(Convert.ToDouble(ostatok) / Convert.ToDouble(12), 2)).ToString()}";
                deltaMonth = 0;
            }
        }
        private void CheckedMonthShow()
        {
            
            if (this.rbMonthes.Checked)
            {
                this.lbOutputShow.Text = "null";
                this.lbOutputShow.Text = $"{ReturnMonth()}";
            }
        }
        private void CheckedDaysShow()
        {
            if (this.rbDays.Checked)
            {
                try
                {
                    this.lbOutputShow.Text = "null";
                    DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
                    DateTime nowDate = new DateTime();
                    nowDate = DateTime.Now;
                    System.TimeSpan delta = inputDate.Subtract(nowDate);
                    this.lbOutputShow.Text = $"{delta.Days.ToString()}";
                    deltaMonth = 0;
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Неправильный формат ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CheckedMinutesShow()
        {
            if (this.rbMinute.Checked)
            {
                try
                {
                    this.lbOutputShow.Text = "null";
                    DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
                    DateTime nowDate = new DateTime();
                    nowDate = DateTime.Now;
                    System.TimeSpan delta = inputDate.Subtract(nowDate);
                    int min = delta.Days * 24 * 60;
                    this.lbOutputShow.Text = $"{(delta.Minutes + min).ToString()}";
                    deltaMonth = 0;
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Неправильный формат ввода.","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CheckedSecundsShow()
        {
            if (this.rbSec.Checked)
            {
                try
                {
                    this.lbOutputShow.Text = "null";
                    DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
                    DateTime nowDate = new DateTime();
                    nowDate = DateTime.Now;
                    System.TimeSpan delta = inputDate.Subtract(nowDate);
                    int sec = delta.Days * 24 * 60 * 60;
                    this.lbOutputShow.Text = $"{(delta.Seconds + sec).ToString()}";
                    deltaMonth = 0;
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Неправильный формат ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mtbInputDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                CheckedYearsShow();
                CheckedMonthShow();
                CheckedDaysShow();
                CheckedMinutesShow();
                CheckedSecundsShow();
            }
        }

        private void rbYears_CheckedChanged(object sender, EventArgs e)
        {
            if (mtbInputDate.Text != null)
            {
                this.lbOutputShow.Text = "null";
                CheckedYearsShow();
            }
        }

        private void rbMonthes_CheckedChanged(object sender, EventArgs e)
        {
            this.lbOutputShow.Text = "null";
            CheckedMonthShow();
        }

        private void rbDays_CheckedChanged(object sender, EventArgs e)
        {
            this.lbOutputShow.Text = "null";
            CheckedDaysShow();
        }

        private void rbMinute_CheckedChanged(object sender, EventArgs e)
        {
            this.lbOutputShow.Text = "null";
            CheckedMinutesShow();
        }

        private void rbSec_CheckedChanged(object sender, EventArgs e)
        {
            this.lbOutputShow.Text = "null";
            CheckedSecundsShow();
        }

        private void HowTimeTo_Load(object sender, EventArgs e)
        {
            deltaMonth = 0;
        }
    }
}
