using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_One_ShutkovWinForms
{
    public partial class Resume : Form
    {
        //      Вывести на экран свое(краткое!!!) резюме с помощью последовательности MessageBox’ов(числом не менее трех). Причем на заголовке
        //      последнего должно отобразиться среднее число символов на странице (общее количество символов в резюме / количество MessageBox’ов).

        public string str { get; private set; } = null;
        public static int res { get; private set; } = 0;
        
        private static void Result(string tempStr)
        {
            res += tempStr.Length;

        }

        public Resume()
        {
            InitializeComponent();
            str = "Резуме Студента Академии Шаг - Шутков Дмитрий Викторович...";
            DialogResult result = MessageBox.Show(str, "РЕЗЮМЕ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Result(str);
            if (result == DialogResult.OK)
            {
                str = "Дата рождения - 28.10.1984";
                result = MessageBox.Show(str, "РЕЗЮМЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Result(str);
                if (result == DialogResult.OK)
                {
                    str = "Контактный телефон - 097 - 984 - 76 - 36";
                    result = MessageBox.Show(str, "РЕЗЮМЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Result(str);
                    if (result == DialogResult.OK)
                    {
                        res = res / 4;
                        result = MessageBox.Show("Всего доброго! Среднее количество символов = " + res.ToString(), "РЕЗЮМЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Вы нажали кнопку Cancel");
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Вы нажали кнопку Cancel");
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Вы нажали кнопку Cancel");
            }
        }
    }
}
