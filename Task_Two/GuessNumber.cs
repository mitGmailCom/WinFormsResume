using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Написать функцию, которая «угадывает» задуманное пользова телем число от 1 до 2000. Для запроса к пользователю использовать MessageBox.После
//того, как число отгадано, необходимо вывести количество запросов, потребовавшихся для этого, и предоставить пользователю возможность сыграть
//еще раз, не выходя из программы (MessageBox’ы оформляются кнопками и значками соответственно ситуации).

namespace Task_Two
{
    public partial class GuessNumber : Form
    {
        public GuessNumber()
        {
            InitializeComponent();
        }
        private int flag { get; set; } = 0;
        private int countIter { get; set; } = 0;
        private int number { get; set; } = 0;
        private int firstPointRange { get; set; } = 1;
        private int lastPointRange { get; set; } = 10;
        DialogResult result;

        private void Rnd()
        {
            Random rand = new Random();
            number = rand.Next(firstPointRange, lastPointRange); 
        }
        private void StartGame()
        {
            do
            {
                result = MessageBox.Show($"Если ??? > {number} -> YES/n??? < {number} -> NO", "Угадай число", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    firstPointRange = number;
                    Rnd();
                    countIter++;
                    if (lastPointRange - firstPointRange == 1)
                        flag = 1;
                }
                if (result == DialogResult.No)
                {
                    lastPointRange = number;
                    Rnd();
                    countIter++;
                    if (lastPointRange - firstPointRange == 1)
                        flag = 1;
                }
            } while (flag == 0);
            result = MessageBox.Show($"{lastPointRange - 1}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result = MessageBox.Show("Загадайте число от 1 до 2000!", "Угадай число", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                Rnd();
                StartGame();
        }
    }
}
