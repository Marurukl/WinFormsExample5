using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        private int priceOil80 = 89, priceOil92 = 142, priceOil95 = 161 , priceOilDt=140;
        private int priceInCafe = 0;
        private int priceAllClients = 0;
        private int time = 0;
        private int stopTime = 10;
        public Form1()
        {
            InitializeComponent();
            textBoxLiters.Enabled = false;
            textBoxMoneyClient.Enabled = false;
            textBoxSumHotDogs.Enabled = false;
            textBoxSumBurgers.Enabled = false;
            textBoxSumFrenchFries.Enabled = false;
            textBoxSumCocaCola.Enabled = false;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
            labelNewClient.Visible = false;
        }
        private void AllEnabledFalse()
        {
            comboBoxOils.Enabled = false;
            checkBoxBurger.Enabled = false;
            checkBoxCocaCola.Enabled = false;
            checkBoxFrenchfries.Enabled = false;
            checkBoxHotDog.Enabled = false;
            radioButtonClientMoney.Enabled = false;
            radioButtonLiters.Enabled = false;
            textBoxLiters.Enabled = false;
            textBoxMoneyClient.Enabled = false;
            textBoxSumBurgers.Enabled = false;
            textBoxSumCocaCola.Enabled = false;
            textBoxSumFrenchFries.Enabled = false;
            textBoxSumHotDogs.Enabled = false;
        }
        private void AllEnabledTrue()
        {
            comboBoxOils.Enabled = true;
            checkBoxBurger.Enabled = true;
            checkBoxCocaCola.Enabled = true;
            checkBoxFrenchfries.Enabled = true;
            checkBoxHotDog.Enabled = true;
            radioButtonClientMoney.Enabled = true;
            radioButtonLiters.Enabled = true;
        }
        private void ButtonMath_Click(object sender, EventArgs e)
        {
            labelToPayForTheAll.Text = (Int32.Parse(labelToPayForTheMini.Text) + Int32.Parse(labelToPayForTheOil.Text)).ToString();
            AllEnabledFalse();
            timerForCheckNewClient.Enabled = true;
            
            
        }

        private void ComboBoxOils_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOils.Text == "АИ-80")
            {
                textBoxPriceForOil.Text = priceOil80.ToString();
            }
            else if (comboBoxOils.Text == "АИ-92")
            {
                textBoxPriceForOil.Text = priceOil92.ToString();
            }
            else if (comboBoxOils.Text == "АИ-95")
            {
                textBoxPriceForOil.Text = priceOil95.ToString();
            }
            else if (comboBoxOils.Text == "Дизель")
            {
                textBoxPriceForOil.Text = priceOilDt.ToString();
            }
        }

        private void RadioButtonLiters_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLiters.Enabled = true;
            textBoxMoneyClient.Enabled = false;
        }

        private void TextBoxMoneyClient_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMoneyClient.Text))
            {
                labelToPayForTheOil.Text = textBoxMoneyClient.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxOils.Text = "АИ-80";
        }
        private void DeleteAllInForm()
        {
            comboBoxOils.Text = "АИ-80";
            radioButtonClientMoney.Checked = false;
            radioButtonLiters.Checked = false;
            textBoxLiters.Enabled = false;
            textBoxMoneyClient.Enabled = false;
            textBoxSumHotDogs.Enabled = false;
            textBoxSumBurgers.Enabled = false;
            textBoxSumFrenchFries.Enabled = false;
            textBoxSumCocaCola.Enabled = false;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
            labelNewClient.Visible = false;
            priceInCafe = 0;
            labelToPayForTheMini.Text = priceInCafe.ToString();
            checkBoxBurger.Checked = false;
            checkBoxCocaCola.Checked = false;
            checkBoxFrenchfries.Checked = false;
            checkBoxHotDog.Checked = false;
            textBoxSumHotDogs.Text = null;
            textBoxSumFrenchFries.Text = null;
            textBoxSumBurgers.Text = null;
            textBoxSumCocaCola.Text = null;
            textBoxLiters.Text = null;
            textBoxMoneyClient.Text = null;
            labelToPayForTheAll.Text = "0";
            labelToPayForTheMini.Text = "0";
            labelToPayForTheOil.Text = "0";
            time = 0;
        }
        private void DeleteAllInMini()
        {
            textBoxSumHotDogs.Enabled = false;
            textBoxSumBurgers.Enabled = false;
            textBoxSumFrenchFries.Enabled = false;
            textBoxSumCocaCola.Enabled = false;
            priceInCafe = 0;
            labelToPayForTheMini.Text = priceInCafe.ToString();
            checkBoxBurger.Checked = false;
            checkBoxCocaCola.Checked = false;
            checkBoxFrenchfries.Checked = false;
            checkBoxHotDog.Checked = false;
            textBoxSumHotDogs.Text = null;
            textBoxSumFrenchFries.Text = null;
            textBoxSumBurgers.Text = null;
            textBoxSumCocaCola.Text = null;
        }
        private void CheckBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotDog.Checked)
            {
                textBoxSumHotDogs.Enabled = true;
                textBoxSumHotDogs.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(textBoxSumHotDogs.Text))
                {
                    priceInCafe = priceInCafe - (Int32.Parse(textBoxSumHotDogs.Text) * Int32.Parse(textBoxPriceHotDog.Text));
                    labelToPayForTheMini.Text = priceInCafe.ToString();
                }
                else
                {
                    DeleteAllInMini();
                }
                textBoxSumHotDogs.Enabled = false;
                textBoxSumHotDogs.Text = null;
            }
        }

        private void CheckBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBurger.Checked)
            {
                textBoxSumBurgers.Enabled = true;
                textBoxSumBurgers.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(textBoxSumBurgers.Text))
                {
                    priceInCafe = priceInCafe - (Int32.Parse(textBoxPriceBurger.Text) * Int32.Parse(textBoxSumBurgers.Text));
                    labelToPayForTheMini.Text = priceInCafe.ToString();
                }
                else
                {
                    DeleteAllInMini();
                }
                textBoxSumBurgers.Enabled = false;
                textBoxSumBurgers.Text = null;
            }
        }

        private void CheckBoxFrenchfries_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrenchfries.Checked)
            {
                textBoxSumFrenchFries.Enabled = true;
                textBoxSumFrenchFries.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(textBoxSumFrenchFries.Text))
                {
                    priceInCafe = priceInCafe - (Int32.Parse(textBoxSumFrenchFries.Text) * Int32.Parse(textBoxPriceFrenchFries.Text));
                    labelToPayForTheMini.Text = priceInCafe.ToString();
                }
                else
                {
                    DeleteAllInMini();
                }
                textBoxSumFrenchFries.Enabled = false;
                textBoxSumFrenchFries.Text = null;
            }
        }

        private void CheckBoxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCocaCola.Checked)
            {
                textBoxSumCocaCola.Enabled = true;
                textBoxSumCocaCola.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(textBoxSumCocaCola.Text))
                {
                    priceInCafe = priceInCafe - (Int32.Parse(textBoxPriceCocaCola.Text) * Int32.Parse(textBoxSumCocaCola.Text));
                    labelToPayForTheMini.Text = priceInCafe.ToString();
                }
                else
                {
                DeleteAllInMini();
            }
            textBoxSumCocaCola.Enabled = false;
                textBoxSumCocaCola.Text = null;
            }
        }

        private void TextBoxSumHotDogs_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSumHotDogs.Text))
            {
                priceInCafe += Int32.Parse(textBoxSumHotDogs.Text) * Int32.Parse(textBoxPriceHotDog.Text);
                labelToPayForTheMini.Text = priceInCafe.ToString();
            }
            
        }

        private void TextBoxSumBurgers_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSumBurgers.Text))
            {
                priceInCafe += Int32.Parse(textBoxSumBurgers.Text) * Int32.Parse(textBoxPriceBurger.Text);
                labelToPayForTheMini.Text = priceInCafe.ToString();
            }
        }

        private void TextBoxSumFrenchFries_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSumFrenchFries.Text))
            {
                priceInCafe += Int32.Parse(textBoxSumFrenchFries.Text) * Int32.Parse(textBoxPriceFrenchFries.Text);
                labelToPayForTheMini.Text = priceInCafe.ToString();
            }
        }

        private void TextBoxSumCocaCola_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSumCocaCola.Text))
            {
                priceInCafe += Int32.Parse(textBoxSumCocaCola.Text) * Int32.Parse(textBoxPriceCocaCola.Text);
                labelToPayForTheMini.Text = priceInCafe.ToString();
            }
        }

        private void timerForCheckNewClient_Tick(object sender, EventArgs e)
        {
            time++;
            labelUnknown.Text = time.ToString();
            if (time == stopTime)
            {
                timerForCheckNewClient.Enabled = false;
                labelNewClient.Visible = true;
                buttonYes.Visible = true;
                buttonNo.Visible = true;
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            priceAllClients += Int32.Parse(labelToPayForTheAll.Text);
            DeleteAllInForm();
            AllEnabledTrue();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            labelNewClient.Visible = false;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
            time = 0;
            timerForCheckNewClient.Enabled=true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Вы заработали сегодня : " + priceAllClients , "Доход за сегодня");
        }

        private void RadioButtonClientMoney_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMoneyClient.Enabled = true;
            textBoxLiters.Enabled = false;
        }

        private void TextBoxLiters_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLiters.Text))
            {
                labelToPayForTheOil.Text = (Convert.ToDouble(textBoxPriceForOil.Text) * Convert.ToInt32(textBoxLiters.Text)).ToString();
            }
        }

        private void TextBoxLiters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
