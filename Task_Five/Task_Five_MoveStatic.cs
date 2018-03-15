using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Разработать приложение «убегающий статик»:) Суть приложения: на форме расположен статический элемент управления(«статик»).Пользователь 
//пытается подвести курсор мыши к «статику», и, если курсор находиться близко со статиком, элемент управления «убегает». Предусмотреть 
//перемещение «статика» только в пределах формы.

namespace Task_Five
{
    public partial class Task_Five_MoveStatik : Form
    {
        private int t { get; set; } = 0;
        public Task_Five_MoveStatik()
        {
            InitializeComponent();
        }

        private void Task_Five_MoveStatik_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.btnMoveStatic.Bounds.ToString());
        }

        private void Task_Five_MoveStatik_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"x = {this.btnMoveStatic.Location.X} Y = {this.btnMoveStatic.Location.Y}";
            int stepX = 5;//(this.btnMoveStatic.Width / 3); //задаем шаг убегания по X
            int stepY = 5;//(this.btnMoveStatic.Height / 3); //задаем шаг убегания по Y

            // с права на лево
            if ((e.Location.X > this.btnMoveStatic.Location.X + this.btnMoveStatic.Width) & (e.Location.X < this.btnMoveStatic.Location.X + this.btnMoveStatic.Width + stepX) & (e.Location.Y > this.btnMoveStatic.Location.Y) & (e.Location.Y < this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height))
            {
                if (this.btnMoveStatic.Location.X > 0)
                    this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X - stepX, this.btnMoveStatic.Location.Y);

                if (this.btnMoveStatic.Location.X > -5 & this.btnMoveStatic.Location.X <= 0)
                {
                    this.btnMoveStatic.Location = new Point(0, this.btnMoveStatic.Location.Y);
                    if ((e.Location.Y > this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height / 2) & (e.Location.X > this.btnMoveStatic.Location.X + this.btnMoveStatic.Width) & (e.Location.X < this.btnMoveStatic.Location.X + this.btnMoveStatic.Width + stepX))
                        if (this.btnMoveStatic.Location.Y > 0)
                            this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, this.btnMoveStatic.Location.Y - stepY);
                    if ((e.Location.Y < this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height / 2) & (e.Location.X > this.btnMoveStatic.Location.X + this.btnMoveStatic.Width) & (e.Location.X < this.btnMoveStatic.Location.X + this.btnMoveStatic.Width + stepX))
                        if (this.btnMoveStatic.Location.Y > 0)
                            this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, this.btnMoveStatic.Location.Y + stepY);
                }
            }

            // сниз вверх
            if ((e.Location.Y > this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height) & (e.Location.Y < this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height + stepY) & (e.Location.X > this.btnMoveStatic.Location.X) & (e.Location.X < this.btnMoveStatic.Location.X + this.btnMoveStatic.Width))
            {
                if (this.btnMoveStatic.Location.Y > 0)
                    this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, this.btnMoveStatic.Location.Y - stepY);

                if (this.btnMoveStatic.Location.Y > -5 & this.btnMoveStatic.Location.Y <= 0)
                {
                    this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, 0);
                    if ((e.Location.X > this.btnMoveStatic.Location.X + this.btnMoveStatic.Width / 2) & (e.Location.Y > this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height) & (e.Location.Y < this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height + stepY))
                        if (this.btnMoveStatic.Location.X > 0)
                            this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X - stepY, this.btnMoveStatic.Location.Y);
                }
            }

            else
                t = 0;
            //if (((this.btnMoveStatic.Left + this.btnMoveStatic.Width + stepX) < (this.ClientSize.Width)) && (e.X <= this.btnMoveStatic.Width / 2))
            //        this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X + stepX, this.btnMoveStatic.Location.Y);
            //if ((this.btnMoveStatic.Left > stepX) && (e.X > this.btnMoveStatic.Width / 2)) this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X - (this.btnMoveStatic.Width / 3), this.btnMoveStatic.Location.Y);

            //if (((this.btnMoveStatic.Top + this.btnMoveStatic.Height + stepY) < (this.ClientSize.Height)) && (e.Y <= this.btnMoveStatic.Height / 2)) this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, this.btnMoveStatic.Location.Y + stepY);
            //if ((this.btnMoveStatic.Top > stepY) && (e.Y > this.btnMoveStatic.Height / 2)) this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, this.btnMoveStatic.Location.Y - stepY);
        }

    }

}
