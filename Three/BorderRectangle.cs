using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Представьте,что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей области формы.Необходимо создать
//следующие обработчики:
//- Обработчик нажатия левой кнопки мыши,который выводит сообщение о том, где находится текущая точка: внутри прямоугольника, снаружи,на границе
//прямоугольника. Домашнее задание №1 Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;
//- Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской(рабочей) области окна в виде:
//Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;
//- Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна текущие координаты мыши x и y.

namespace Three
{
    enum stateMouseCl { InRectangle = 1, OutRectangle = 2, OnRectangle = 3 };

    public partial class BorderRectangle : Form
    {
        DialogResult result;
        private string PressCtrl { get; set; } = null;
        private bool flag { get; set; } = false;
        public BorderRectangle()
        {
            InitializeComponent();
        }

        private void GetBorderRectangle(MouseEventArgs tempE)
        {
            if (PressCtrl == null)
            {
                int borderMaxX = this.ClientSize.Width - 10;
                int borderMaxY = this.ClientSize.Height - 10;
                int borderMinX = 10;
                int borderMinY = 10;
                if ((borderMaxX < tempE.X || borderMaxY < tempE.Y) || (borderMinX > tempE.X || borderMinY > tempE.Y))
                {
                    result = MessageBox.Show($"{stateMouseCl.OutRectangle}", "Событие Click(Левая клавиша)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((borderMaxX > tempE.X & borderMinX < tempE.X & borderMaxY > tempE.Y & borderMinY < tempE.Y) || (borderMinX < tempE.X & borderMaxX > tempE.X & borderMinY < tempE.Y & borderMaxY > tempE.Y))
                {
                    result = MessageBox.Show($"{stateMouseCl.InRectangle}", "Событие Click(Левая клавиша)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((borderMaxX == tempE.X || borderMaxY == tempE.Y) || (borderMinX == tempE.X || borderMinY == tempE.Y))
                {
                    result = MessageBox.Show($"{stateMouseCl.OnRectangle}", "Событие Click(Левая клавиша)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    PressCtrl = null;
            }

            else if (PressCtrl == "Control")
            {
                this.Close();
                //Application.Exit();
            }
            else
                PressCtrl = null;
        }

        private void BorderRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ClientSize.Height < 23 | this.ClientSize.Width < 23)
            {
                result = MessageBox.Show("Клиентская область окна меньше чем предположеный прямоугольник\nТребование: Xmin > 23, Ymin > 23)", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (flag == false)
            {
                this.Text = $"X = {e.Location.X.ToString()} Y = {e.Location.Y.ToString()}";
            }
            if (flag == true)
            {
                this.MouseMove -= this.BorderRectangle_MouseMove;
                this.Text = $"КО: Ширина={this.ClientSize.Width.ToString()} Длина={this.ClientSize.Height.ToString()}";
                this.MouseMove += this.BorderRectangle_MouseMove;
                flag = false;
            }
            else
                flag = false;
        }

        private void BorderRectangle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                flag = true;
            }
            else if (e.Button == MouseButtons.Left)
            {
                GetBorderRectangle(e);
            }
            else
                flag = false;
        }

        private void BorderRectangle_Click(object sender, EventArgs e)
        {
            if (BorderRectangle.ModifierKeys == Keys.Control)
                PressCtrl = BorderRectangle.ModifierKeys.ToString();
            else
                PressCtrl = null;
        }
    }
}
