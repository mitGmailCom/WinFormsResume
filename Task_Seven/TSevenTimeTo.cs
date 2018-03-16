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
            DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
            DateTime nowDate = new DateTime();
            nowDate = DateTime.Now;
            int nowYear = nowDate.Year;
            int targetYear = inputDate.Year;
            int deltaMonth = 0;
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
            return deltaMonth;
        }

        private void mtbInputDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                if (this.rbYears.Checked)
                {
                    int integer = ReturnMonth() / 12;
                    int ostatok = ReturnMonth() % 12;
                    this.lbOutputShow.Text = $"{(integer + Math.Round(Convert.ToDouble(ostatok) / Convert.ToDouble(12), 2)).ToString()}";
                }

                if (this.rbMonthes.Checked)
                {
                    this.lbOutputShow.Text = $"{ReturnMonth()}";
                }

                if(this.rbDays.Checked)
                {
                    DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
                    DateTime nowDate = new DateTime();
                    nowDate = DateTime.Now;
                    System.TimeSpan delta = inputDate.Subtract(nowDate);
                    this.lbOutputShow.Text = $"{delta.Days.ToString()}";
                }

                if (this.rbMinute.Checked)
                {
                    DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
                    DateTime nowDate = new DateTime();
                    nowDate = DateTime.Now;
                    System.TimeSpan delta = inputDate.Subtract(nowDate);
                    int min = delta.Days * 24 * 60;
                    this.lbOutputShow.Text = $"{(delta.Minutes + min).ToString()}";
                }

                if (this.rbSec.Checked)
                {
                    DateTime inputDate = Convert.ToDateTime(this.mtbInputDate.Text.ToString());
                    DateTime nowDate = new DateTime();
                    nowDate = DateTime.Now;
                    System.TimeSpan delta = inputDate.Subtract(nowDate);
                    int sec = delta.Days * 24 * 60 * 60;
                    this.lbOutputShow.Text = $"{(delta.Seconds + sec).ToString()}";
                }
            }
            
        }

        private void rbYears_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
