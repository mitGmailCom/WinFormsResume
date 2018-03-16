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
        Random rnd = new Random();
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
            int stepX = 7;// шаг убегания по X
            int stepY = 7;// шаг убегания по Y

            // с права на лево
            if ((e.Location.X > this.btnMoveStatic.Location.X + this.btnMoveStatic.Width) & (e.Location.X < this.btnMoveStatic.Location.X + this.btnMoveStatic.Width + stepX) & (e.Location.Y > this.btnMoveStatic.Location.Y) & (e.Location.Y < this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height))
            {
                if (this.btnMoveStatic.Location.X > 0)
                    this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X - stepX, this.btnMoveStatic.Location.Y);
                
                // упирается в клиентскую область
                if((this.btnMoveStatic.Location.X > -5) & (this.btnMoveStatic.Location.X <= 0))
                    this.btnMoveStatic.Location = new Point(rnd.Next(this.ClientRectangle.Left, this.ClientRectangle.Right - this.btnMoveStatic.Bounds.Width), rnd.Next(this.ClientRectangle.Top, this.ClientRectangle.Bottom - this.btnMoveStatic.Bounds.Height));
            }


            // сниз вверх
            if ((e.Location.Y > this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height) & (e.Location.Y < this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height + stepY) & (e.Location.X > this.btnMoveStatic.Location.X) & (e.Location.X < this.btnMoveStatic.Location.X + this.btnMoveStatic.Width))
            {
                if (this.btnMoveStatic.Location.Y > 0)
                    this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, this.btnMoveStatic.Location.Y - stepY);

                // упирается в клиентскую область
                if (this.btnMoveStatic.Location.Y >= this.ClientRectangle.Location.Y - stepY & this.btnMoveStatic.Location.Y <= this.ClientRectangle.Location.Y)
                    this.btnMoveStatic.Location = new Point(rnd.Next(this.ClientRectangle.Left, this.ClientRectangle.Right - this.btnMoveStatic.Bounds.Width), rnd.Next(this.ClientRectangle.Top, this.ClientRectangle.Bottom - this.btnMoveStatic.Bounds.Height));
            }

            
            // слева на право
            if ((e.Location.X < this.btnMoveStatic.Location.X) & (e.Location.X > this.btnMoveStatic.Location.X - stepX) & (e.Location.Y > this.btnMoveStatic.Location.Y) & (e.Location.Y < this.btnMoveStatic.Location.Y + this.btnMoveStatic.Height))
            {
                if (this.btnMoveStatic.Location.X < this.ClientRectangle.Width - this.btnMoveStatic.ClientRectangle.Width)
                    this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X + stepX, this.btnMoveStatic.Location.Y);
                
                // упирается в клиентскую область
                if ((this.btnMoveStatic.Location.X >= this.ClientRectangle.Width - this.btnMoveStatic.ClientRectangle.Width) & (this.btnMoveStatic.Location.X <= this.ClientRectangle.Width - this.btnMoveStatic.ClientRectangle.Width + stepX))
                    this.btnMoveStatic.Location = new Point(rnd.Next(this.ClientRectangle.Left, this.ClientRectangle.Right - this.btnMoveStatic.Bounds.Width), rnd.Next(this.ClientRectangle.Top, this.ClientRectangle.Bottom - this.btnMoveStatic.Bounds.Height));
            }


            // сверху вниз
            if ((e.Location.Y < this.btnMoveStatic.Location.Y) & (e.Location.Y > this.btnMoveStatic.Location.Y - stepY) & (e.Location.X > this.btnMoveStatic.Location.X) & (e.Location.X < this.btnMoveStatic.Location.X + this.btnMoveStatic.Width))
            {
                if (this.btnMoveStatic.Location.Y < this.ClientRectangle.Height - this.btnMoveStatic.ClientRectangle.Height)
                    this.btnMoveStatic.Location = new Point(this.btnMoveStatic.Location.X, this.btnMoveStatic.Location.Y + stepY);

                // упирается в клиентскую область
                if ((this.btnMoveStatic.Location.Y >= this.ClientRectangle.Height - this.btnMoveStatic.ClientRectangle.Height) & (this.btnMoveStatic.Location.Y < this.ClientRectangle.Height - this.btnMoveStatic.ClientRectangle.Height + stepY))
                    this.btnMoveStatic.Location = new Point(rnd.Next(this.ClientRectangle.Left, this.ClientRectangle.Right - this.btnMoveStatic.Bounds.Width), rnd.Next(this.ClientRectangle.Top, this.ClientRectangle.Bottom - this.btnMoveStatic.Bounds.Height));
            }
           
            else
                t = 0;
            }
        //}
    }
}
