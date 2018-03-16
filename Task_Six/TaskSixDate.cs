using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Написать программу, которая по введенной дате определяет день недели.Результат выводить в текстовое поле (желательно по-русски).

namespace Task_Six
{
    public partial class TaskSix : Form
    {
        private Dictionary<string,string> dictionaryDays;
        public TaskSix()
        {
            InitializeComponent();
        }

        private void TaskSix_Load(object sender, EventArgs e)
        {
            dictionaryDays = new Dictionary<string, string>();
            dictionaryDays.Add("Понедельник", "Monday");
            dictionaryDays.Add("Вторник", "Tuesday");
            dictionaryDays.Add("Среда", "Wednesday");
            dictionaryDays.Add("Четверг", "Thursday");
            dictionaryDays.Add("Пятница", "Friday");
            dictionaryDays.Add("Суббота", "Saturday");
            dictionaryDays.Add("Воскресенье", "Sunday");
        }

        private void dtpTaskSix_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in dictionaryDays)
            {
                if (dtpTaskSix.Value.DayOfWeek.ToString() == item.Value)
                    this.tbTaskSix.Text = item.Key;

            }
        }
    }
}
