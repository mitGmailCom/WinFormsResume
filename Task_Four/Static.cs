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

namespace Task_Four
{
    public partial class Static : Form
    {
        DialogResult res;
        private int X1 { get; set; } = 0;
        private int Y1 { get; set; } = 0;
        private int X4 { get; set; } = 0;
        private int Y4 { get; set; } = 0;
        private int X2 { get; set; } = 0;
        private int Y2 { get; set; } = 0;
        private int X3 { get; set; } = 0;
        private int Y3 { get; set; } = 0;
        private Point p1;// { get; set; }
        private Point p2;// { get; set; }
        private Point p3;// { get; set; }
        private Point p4;// { get; set; }
        private int HRect { get; set; } = 0;
        private int WRect { get; set; } = 0;
        private string NameRect { get; set; } = null;
        private string FirstPartNameRect { get; set; } = "Rectangle";
        public int CountRect { get; private set; } = 0;
        private bool flag { get; set; } = false;

        public Static()
        {
            InitializeComponent();
        }

        private void Static_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X1 = e.Location.X;
                Y1 = e.Location.Y;
                p1.X = e.Location.X;
                p1.Y = e.Location.Y;
                flag = true;
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
                    X4 = e.Location.X;
                    Y4 = e.Location.Y;
                    p4.X = e.Location.X;
                    p4.Y = e.Location.Y;
                    p2.X = p4.X;
                    p2.Y = p1.Y;
                    p3.X = p1.X;
                    p3.Y = p4.Y;
                    X2 = X1;
                    Y2 = Y4;
                    X3 = X4;
                    Y3 = Y1;
                    WRect = p2.X - p1.X;
                    HRect = p3.Y - p1.Y;
                    CountRect++;
                    createNameRect();
                }
            }
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
            rect1.Size = new Size(HRect, WRect);
            rect1.Name = NameRect;
            rect1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(rect1);
            rect1.BringToFront();
            //rect1.Visible = true;
            rect1.Enabled = true;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Static_MouseDown);
            //rect1.MouseDown += this.label1 

        }

        private void Static_Load(object sender, EventArgs e)
        {

        }
    }
}


