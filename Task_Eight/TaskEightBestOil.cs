using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Eight
{
    public partial class TaskEightBestOil : Form
    {
        //List<string> listFuel;
        public TaskEightBestOil()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TaskEightBestOil_Load(object sender, EventArgs e)
        {
            Fuel A92 = new Fuel(); A92.NameFuel = "92"; A92.Price = 25.20;
            Fuel A95 = new Fuel(); A95.NameFuel = "95"; A95.Price = 25.20;
            Fuel A98 = new Fuel(); A98.NameFuel = "98"; A98.Price = 25.20;
            Fuel A95Plus = new Fuel(); A95Plus.NameFuel = "95Plus"; A95Plus.Price = 25.20;
            Fuel DZ = new Fuel(); DZ.NameFuel = "ДизТопливо"; DZ.Price = 25.20;
            Fuel Gaz = new Fuel(); Gaz.NameFuel = "Пропан"; Gaz.Price = 25.20;

            cbTypeFuel.Items.Add(A92.NameFuel);
            cbTypeFuel.Items.Add(A95.NameFuel);
            cbTypeFuel.Items.Add(A98.NameFuel);
            cbTypeFuel.Items.Add(A95Plus.NameFuel);
            cbTypeFuel.Items.Add(DZ.NameFuel);
            cbTypeFuel.Items.Add(Gaz.NameFuel);

        }
    }
}
