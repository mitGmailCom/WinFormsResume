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
        List<Fuel> listFuel;
        List<Cafe> listCafe;
        public int SumHotD { get; private set; } = 0;
        public int SumHumbur { get; private set; } = 0;
        public int SumFri { get; private set; } = 0;
        public int SumKola { get; private set; } = 0;
        double resInSum = 0.0;
        public TaskEightBestOil()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TaskEightBestOil_Load(object sender, EventArgs e)
        {
            listFuel = new List<Fuel>();
            listCafe = new List<Cafe>();
            Fuel A92 = new Fuel(); A92.NameFuel = "92"; A92.Price = 25.20;
            Fuel A95 = new Fuel(); A95.NameFuel = "95"; A95.Price = 27.20;
            Fuel A98 = new Fuel(); A98.NameFuel = "98"; A98.Price = 29.20;
            Fuel A95Plus = new Fuel(); A95Plus.NameFuel = "95Plus"; A95Plus.Price = 27.20;
            Fuel DZ = new Fuel(); DZ.NameFuel = "ДизТопливо"; DZ.Price = 24.50;
            Fuel Gaz = new Fuel(); Gaz.NameFuel = "Пропан"; Gaz.Price = 11.05;
            listFuel.Add(A92);
            listFuel.Add(A95);
            listFuel.Add(A98);
            listFuel.Add(A95Plus);
            listFuel.Add(DZ);
            listFuel.Add(Gaz);
            Cafe hotdog = new Cafe(); hotdog.NameProduct = "Хот-дог"; hotdog.PriceProduct = 22.00;
            Cafe gamburger = new Cafe(); gamburger.NameProduct = "Гамбургер"; gamburger.PriceProduct = 21.00;
            Cafe fri = new Cafe(); fri.NameProduct = "Картошка-фри"; fri.PriceProduct = 20.00;
            Cafe kola = new Cafe(); kola.NameProduct = "Кока-кола"; kola.PriceProduct = 18.00;
            listCafe.Add(hotdog);
            listCafe.Add(gamburger);
            listCafe.Add(fri);
            listCafe.Add(kola);
            cbTypeFuel.Items.Add(A92.NameFuel);
            cbTypeFuel.Items.Add(A95.NameFuel);
            cbTypeFuel.Items.Add(A98.NameFuel);
            cbTypeFuel.Items.Add(A95Plus.NameFuel);
            cbTypeFuel.Items.Add(DZ.NameFuel);
            cbTypeFuel.Items.Add(Gaz.NameFuel);
            tbPriceHotDog.Text = hotdog.PriceProduct.ToString();
            tbPriceHamburger.Text = gamburger.PriceProduct.ToString();
            tbPricePotatoFri.Text = fri.PriceProduct.ToString();
            tbPriceCola.Text = kola.PriceProduct.ToString();
            
        }

        private void cbTypeFuel_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listFuel.Count; i++)
            {
                if (cbTypeFuel.SelectedItem.ToString() == listFuel[i].NameFuel)
                    tbPrice.Text = listFuel[i].Price.ToString();
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (masktbCountHotDog.Text == "" & cbHotDog.Checked)
                SumHotD = 0;
            if (masktbCountHotDog.Text != "" & cbHotDog.Checked)
            {
                SumHotD = Convert.ToInt32(masktbCountHotDog.Text) * Convert.ToInt32(tbPriceHotDog.Text);
            }
            //if ((masktbCountHotDog.Text != "" & !cbHotDog.Checked))
            //    SumHotD = 0;
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Неверный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHotDog.Checked)
            {
                lbTotalSumShow.Text = "0";
                if (masktbCountHotDog.Text == "" & cbHotDog.Checked)
                    SumHotD = 0;
                if (masktbCountHotDog.Text != "" & cbHotDog.Checked)
                    SumHotD = Convert.ToInt32(masktbCountHotDog.Text) * Convert.ToInt32(tbPriceHotDog.Text);
            }
            if ((masktbCountHotDog.Text != "" & !cbHotDog.Checked))
                SumHotD = 0;
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void masktbCountHamburger_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Неверный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void masktbCountHamburger_TextChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (masktbCountHamburger.Text == "" & cbHamburger.Checked)
                SumHumbur = 0;
            if (masktbCountHamburger.Text != "" & cbHamburger.Checked)
                SumHumbur = Convert.ToInt32(masktbCountHamburger.Text) * Convert.ToInt32(tbPriceHamburger.Text);
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void cbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHamburger.Checked)
            {
                lbTotalSumShow.Text = "0";
                if (masktbCountHamburger.Text == "" & cbHamburger.Checked)
                    SumHumbur = 0;
                if (masktbCountHamburger.Text != "" & cbHamburger.Checked)
                    SumHumbur = Convert.ToInt32(masktbCountHamburger.Text) * Convert.ToInt32(tbPriceHamburger.Text);
            }
            if ((masktbCountHamburger.Text != "" & !cbHamburger.Checked))
                SumHumbur = 0;
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void masktbCountPotatoFri_TextChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (masktbCountPotatoFri.Text == "" & cbPotatoFri.Checked)
                SumFri = 0;
            if (masktbCountPotatoFri.Text != "" & cbPotatoFri.Checked)
                SumFri = Convert.ToInt32(masktbCountPotatoFri.Text) * Convert.ToInt32(tbPricePotatoFri.Text);
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void cbPotatoFri_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPotatoFri.Checked)
            {
                lbTotalSumShow.Text = "0";
                if (masktbCountPotatoFri.Text == "" & cbPotatoFri.Checked)
                    SumFri = 0;
                if (masktbCountPotatoFri.Text != "" & cbPotatoFri.Checked)
                    SumFri = Convert.ToInt32(masktbCountPotatoFri.Text) * Convert.ToInt32(tbPricePotatoFri.Text);
            }
            if ((masktbCountPotatoFri.Text != "" & !cbPotatoFri.Checked))
                SumFri = 0;
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void masktbCountPotatoFri_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Неверный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void masktbCountCola_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Неверный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void masktbCountCola_TextChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (masktbCountCola.Text == "" & cbCola.Checked)
                SumKola = 0;
            if (masktbCountCola.Text != "" & cbCola.Checked)
                SumKola = Convert.ToInt32(masktbCountCola.Text) * Convert.ToInt32(tbPriceCola.Text);
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void cbCola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCola.Checked)
            {
                lbTotalSumShow.Text = "0";
                if (masktbCountCola.Text == "" & cbCola.Checked)
                    SumKola = 0;
                if (masktbCountCola.Text != "" & cbCola.Checked)
                    SumKola = Convert.ToInt32(masktbCountCola.Text) * Convert.ToInt32(tbPriceCola.Text);
            }
            if ((masktbCountCola.Text != "" & !cbCola.Checked))
                SumKola = 0;
            lbSumCafeShow.Text = (SumHotD + SumHumbur + SumFri + SumKola).ToString();
        }

        private void rbCountFuel_CheckedChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (rbCountFuel.Checked)
            {
                tbSumClientInput.Enabled = false;
                tbLFuel.Enabled = true;
                lbGrnToPayFuel.Text = "грн.";
                gbToPayFuel.Text = "К оплате:";
                lbSumFuelShow.Text = "0";
                tbLFuel.Text = "";
                lbOutSumShow.Text = "";
            }
        }

        private void tbLFuel_TextChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (tbPrice.Text != "" & tbLFuel.Text != "")
            {
                int res;
                bool isNum = int.TryParse(tbLFuel.Text, out res);
                if (isNum)
                    lbSumFuelShow.Text = (Convert.ToDouble(tbPrice.Text) * (double)res).ToString();
            }
            if (tbLFuel.Text == null || tbLFuel.Text == "")
                lbSumFuelShow.Text = "0";
        }

        private void rbTypeSum_CheckedChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (rbTypeSum.Checked)
            {
                tbLFuel.Enabled = false;
                tbSumClientInput.Enabled = true;
                lbGrnToPayFuel.Text = "л.";
                gbToPayFuel.Text = "К заправке:";
                lbSumFuelShow.Text = "0";
                tbSumClientInput.Text = "";
                lbOutSumShow.Text = "";
            }
        }

        private void tbSumClientInput_TextChanged(object sender, EventArgs e)
        {
            lbTotalSumShow.Text = "0";
            if (tbPrice.Text != "" & tbSumClientInput.Text != "")
            {
                int res;
                bool isNum = int.TryParse(tbSumClientInput.Text, out res);
                if (isNum)
                    lbSumFuelShow.Text = Math.Round(((double)res / Convert.ToDouble(tbPrice.Text)), 2).ToString();
            }
            if (tbSumClientInput.Text == null || tbSumClientInput.Text == "")
                lbSumFuelShow.Text = "0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbCountFuel.Checked == true)
            {
                lbTotalSumShow.Text = (Convert.ToDouble(lbSumFuelShow.Text) + Convert.ToDouble(lbSumCafeShow.Text)).ToString();
            }
            if (rbTypeSum.Checked == true)
            {
                lbTotalSumShow.Text = (Convert.ToDouble(tbSumClientInput.Text) + Convert.ToDouble(lbSumCafeShow.Text)).ToString();
            }
            if (tbInSum.Text != "")
            {
                lbOutSumShow.Text = "0";
                PayBack();
            }
        }

        private void tbInSum_TextChanged(object sender, EventArgs e)
        {
            //double resInSum;
            bool isNum = double.TryParse(tbInSum.Text, out resInSum);
            if (isNum)
            {
                lbOutSumShow.Text = "0";
                if (resInSum > Convert.ToDouble(lbTotalSumShow.Text))
                {
                    lbOutSumShow.Text = (resInSum - Convert.ToDouble(lbTotalSumShow.Text)).ToString();
                }
             }
            //else
            //    MessageBox.Show("Не верный ввод!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tbInSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                //if (resInSum < Convert.ToDouble(lbTotalSumShow.Text))
                //    MessageBox.Show("Не хватает денег", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //if (resInSum > Convert.ToDouble(lbTotalSumShow.Text))
                //{
                //    lbOutSumShow.Text = (resInSum - Convert.ToDouble(lbTotalSumShow.Text)).ToString();
                //}
                PayBack();
            }
        }

        private void PayBack()
        {
            if (resInSum < Convert.ToDouble(lbTotalSumShow.Text))
            {
                MessageBox.Show("Не хватает денег", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (resInSum > Convert.ToDouble(lbTotalSumShow.Text))
            {
                lbOutSumShow.Text = (resInSum - Convert.ToDouble(lbTotalSumShow.Text)).ToString();
            }
        }

        private void lbTotalSumShow_TextChanged(object sender, EventArgs e)
        {
            if (tbInSum.Text != "")
            {
                if (lbTotalSumShow.Text != "")
                    PayBack();
            }
                    
        }
    }
}
