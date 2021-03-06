﻿using System;
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
        private int lastPointRange { get; set; } = 2000;
        DialogResult result;

        private void Number()
        {
            number = (firstPointRange + lastPointRange) / 2;
        }

        private void Compare()
        {
            if (lastPointRange - firstPointRange == 0)
            {
                number = lastPointRange;
                flag = 1;
            }
        }

        private void StartGame()
        {
            do
            {
                if (flag == 0)
                {
                    result = MessageBox.Show($"'???' > {number} --> YES\n'???' < {number} --> NO\n'???' = {number} --> CANCEL", "Угадай число", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        firstPointRange = number + 1;
                        Compare();
                        if (flag == 1)
                            break;
                        Number();
                        countIter++;
                    }
                    if (result == DialogResult.No)
                    {
                        lastPointRange = number - 1;
                        Compare();
                        if (flag == 1)
                            break;
                        Number();
                        countIter++;
                    }
                    if (result == DialogResult.Cancel)
                        flag = 1;
                    else
                        flag = 0;
                }
            } while (flag == 0);
            result = MessageBox.Show($"Вы загадали число - {number} Использовано - {countIter} попытки(ок)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result = MessageBox.Show("Загадайте число от 1 до 2000!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                Number();
                StartGame();
        }
    }
}
