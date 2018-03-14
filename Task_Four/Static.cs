using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Разработать приложение, созданное на основе форме.
//-Пользователь «щелкает» левой кнопкой мыши по форме и,не отпуская кнопку, ведет по ней мышку, а в момент отпускания кнопки по полученным
//координатам прямоугольника(вам, конечно, известно, что двух точек на плоскости достаточно для создания прямоугольника) необходимо создать
//«статик», который содержит свой порядковый номер (имеется в виду порядок появления на форме).
//-Минимальный размер«статика»составляет 10х10,при попытке создания элемента меньших размеров пользователь должен увидеть соответствующее предупреждение.
//-При щелчке правой кнопкой мыши над поверхностью «статика» в заголовке окна должна появиться информация о его площади и координатах
//(относительно формы).
//В случае, если в точке щелчка находится несколько «статиков», то предпочтение отдается «статику» с наибольшим порядковым номером.
//-При двойном щелчке левой кнопки мыши над поверхностью «статика» он должен исчезнуть с формы.В случае, если в точке щелчка находится
//несколько «статиков», то предпочтение отдается «статику» с наименьшим порядковым номером.
namespace Task_Four
{
    public partial class Static : Form
    {
        DialogResult res;
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private int HRect { get; set; } = 0;
        private int WRect { get; set; } = 0;
        private string NameRect { get; set; } = null;
        private string FirstPartNameRect { get; set; } = "Rectangle";
        public int CountRect { get; private set; } = 0;
        private bool flag { get; set; } = false; // индикатор для mousedown 
        private int flagDoubleClick { get; set; } = 0;
        private int minX { get; } = 10;
        private int minY { get; } = 10;

        public Static()
        {
            InitializeComponent();
        }

        private void Static_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Text = $"x = {e.Location.X.ToString()} y = {e.Location.Y.ToString()}";
                p1.X = e.Location.X;
                p1.Y = e.Location.Y;
                flag = true;
                flagDoubleClick++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                if(CountRect > 0)
                {
                    int tempP = 15;
                    int count = 0;
                    int ind = 0;
                    for(int i = 0; i < this.Controls.Count; i++)
                    {
                        if ((e.Location.X > this.Controls[i].Location.X & e.Location.X < this.Controls[i].Location.X + this.Controls[i].Width) & (e.Location.Y < this.Controls[i].Location.Y & e.Location.Y > this.Controls[i].Location.Y - tempP))
                        {
                            if (Convert.ToInt32(this.Controls[i].Text) > count)
                            {
                                count = Convert.ToInt32(this.Controls[i].Text);
                                ind = i;
                            }
                        }
                    }
                    this.Text = $"{this.Controls[ind].Name} P1({this.Controls[ind].Location.X},{this.Controls[ind].Location.Y}) P2({this.Controls[ind].Location.X + this.Controls[ind].Width},{this.Controls[ind].Location.Y}) P3({this.Controls[ind].Location.X},{this.Controls[ind].Location.Y + this.Controls[ind].Height}) P4({this.Controls[ind].Location.X + this.Controls[ind].Width},{this.Controls[ind].Location.Y + this.Controls[ind].Height}) S = {this.Controls[ind].Width * this.Controls[ind].Height}";
                }
            }

            else
                res = MessageBox.Show("Вы нажали не левую кнопку мыши!", "");
        }

        private void Static_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                if(e.Button == MouseButtons.Left)
                {
                    if (e.Location.X - p1.X > minX & e.Location.Y - p1.Y > minY)
                    {
                        this.Text = $"x = {e.Location.X.ToString()} y = {e.Location.Y.ToString()}";
                        p4.X = e.Location.X;
                        p4.Y = e.Location.Y;
                        WRect = p4.X - p1.X;
                        HRect = p4.Y - p1.Y;
                        CountRect++;
                        createNameRect();
                    }
                    else
                        MessageBox.Show($"Минимальный размер Статика должен быть - 10Х10", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //if (WRect < 10 | HRect < 10)
                    //{
                    //    MessageBox.Show($"Минимальный размер Статика должен быть - 10Х10", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }
            }
            flagDoubleClick++;
        }

        private void createNameRect()
        {
            NameRect = FirstPartNameRect + CountRect.ToString();
            DrawRect();
        }
        private void DrawRect()
        {
            Label rect1 = new Label();
            rect1.SuspendLayout();
            rect1.Location = p1;
            rect1.Height = HRect;
            rect1.Width = WRect;
            rect1.Name = NameRect;
            rect1.BorderStyle = BorderStyle.FixedSingle;
            rect1.MinimumSize = new Size(10, 10);
            rect1.Text = CountRect.ToString();
            this.Controls.Add(rect1);
            rect1.SuspendLayout();
            rect1.Enabled = false;
            rect1.BringToFront();

        }

        private void Static_Load(object sender, EventArgs e)
        {

        }

        private void Static_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CountRect > 0)
                {
                    int tempP = 15;
                    int count = 0;
                    int ind = 0;
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if ((e.Location.X > this.Controls[i].Location.X & e.Location.X < this.Controls[i].Location.X + this.Controls[i].Width) & (e.Location.Y < this.Controls[i].Location.Y & e.Location.Y > this.Controls[i].Location.Y - tempP))
                        {
                            //if (Convert.ToInt32(this.Controls[i].Text) > count)
                            //{
                            //count = Convert.ToInt32(this.Controls[i].Text);
                            ind = i;
                            break;
                            //}
                        }
                    }
                    this.Text = $"{this.Controls[ind].Name} P1({this.Controls[ind].Location.X},{this.Controls[ind].Location.Y}) P2({this.Controls[ind].Location.X + this.Controls[ind].Width},{this.Controls[ind].Location.Y}) P3({this.Controls[ind].Location.X},{this.Controls[ind].Location.Y + this.Controls[ind].Height}) P4({this.Controls[ind].Location.X + this.Controls[ind].Width},{this.Controls[ind].Location.Y + this.Controls[ind].Height}) S = {this.Controls[ind].Width * this.Controls[ind].Height}";
                }
            }
        }
    }
}


