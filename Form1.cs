using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Translator
{
    public partial class TranslatorPage : Form
    {
        private Button[] DecButtons = new Button[10];
        private Button[] BinButtons = new Button[2];
        private Button[] HexButtons = new Button[16];
        private Button[] HexDecButtons = new Button[10];

        public TranslatorPage()
        {
            InitializeComponent();
        }

        private void TranslatorPage_Load(object sender, EventArgs e)
        {
            DecButtons[0] = DecBtn0;
            DecButtons[1] = DecBtn1;
            DecButtons[2] = DecBtn2;
            DecButtons[3] = DecBtn3;
            DecButtons[4] = DecBtn4;
            DecButtons[5] = DecBtn5;
            DecButtons[6] = DecBtn6;
            DecButtons[7] = DecBtn7;
            DecButtons[8] = DecBtn8;
            DecButtons[9] = DecBtn9;

            BinButtons[0] = BinBtn0;
            BinButtons[1] = BinBtn1;

            HexButtons[0] = HexBtn0;
            HexButtons[1] = HexBtn1;
            HexButtons[2] = HexBtn2;
            HexButtons[3] = HexBtn3;
            HexButtons[4] = HexBtn4;
            HexButtons[5] = HexBtn5;
            HexButtons[6] = HexBtn6;
            HexButtons[7] = HexBtn7;
            HexButtons[8] = HexBtn8;
            HexButtons[9] = HexBtn9;
            HexButtons[10] = HexBtnA;
            HexButtons[11] = HexBtnB;
            HexButtons[12] = HexBtnC;
            HexButtons[13] = HexBtnD;
            HexButtons[14] = HexBtnE;
            HexButtons[15] = HexBtnF;

            HexDecButtons[0] = HexDecBtn0;
            HexDecButtons[1] = HexDecBtn1;
            HexDecButtons[2] = HexDecBtn2;
            HexDecButtons[3] = HexDecBtn3;
            HexDecButtons[4] = HexDecBtn4;
            HexDecButtons[5] = HexDecBtn5;
            HexDecButtons[6] = HexDecBtn6;
            HexDecButtons[7] = HexDecBtn7;
            HexDecButtons[8] = HexDecBtn8;
            HexDecButtons[9] = HexDecBtn9;
        }

        #region Binary Page
        #region Decimal Buttons
        private void DecBtn0_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("0");
        }

        private void DecBtn1_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("1");
        }

        private void DecBtn2_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("2");
        }

        private void DecBtn3_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("3");
        }

        private void DecBtn4_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("4");
        }

        private void DecBtn5_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("5");
        }

        private void DecBtn6_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("6");
        }

        private void DecBtn7_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("7");
        }

        private void DecBtn8_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("8");
        }

        private void DecBtn9_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("9");
        }
        #endregion

        #region Binary Buttons

        private void BinBtn0_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("0");
        }

        private void BinBtn1_Click(object sender, EventArgs e)
        {
            BinInpBox.AppendText("1");
        }

        #endregion

        private void BinToIntBtn_CheckedChanged(object sender, EventArgs e)
        {
            BinInpBox.Clear();
            BinOutBox.Clear();
            foreach (Button btn in DecButtons)
            {
                btn.Visible = false;
            }
            foreach(Button btn in BinButtons)
            {
                btn.Visible = true;
            }
        }

        private void IntToBinBtn_CheckedChanged(object sender, EventArgs e)
        {
            BinInpBox.Clear();
            BinOutBox.Clear();
            foreach(Button btn in BinButtons)
            {
                btn.Visible = false;
            }
            foreach(Button btn in DecButtons)
            {
                btn.Visible = true;
            }
        }

        private void BinTraBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BinInpBox.Text))
            {
                if (IntToBinBtn.Checked)
                {
                    try
                    {
                        BinOutBox.Text = "Int to bin";
                        //BinOutBox.Text = [Metodo de conversão da dll]
                    }
                    catch (Exception)
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Número inválido", "Erro de número");
                    }
                }
                else if (BinToIntBtn.Checked)
                {
                    try
                    {
                        BinOutBox.Text = "Bin to int";
                        //BinOutBox.Text = [Metodo de conversão da dll]
                    }
                    catch (Exception)
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Número inválido", "Erro de número");
                    }
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Nenhum nímero foi digitado", "Error NULL");
            }
        }

        #endregion

        #region HEX Page

        #region HEX Buttons
        private void HexBtn0_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("0");
        }

        private void HexBtn1_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("1");
        }

        private void HexBtn2_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("2");
        }

        private void HexBtn3_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("3");
        }

        private void HexBtn4_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("4");
        }

        private void HexBtn5_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("5");
        }

        private void HexBtn6_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("6");
        }

        private void HexBtn7_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("7");
        }

        private void HexBtn8_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("8");
        }

        private void HexBtn9_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("9");
        }

        private void HexBtnA_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("A");
        }

        private void HexBtnB_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("B");
        }

        private void HexBtnC_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("C");
        }

        private void HexBtnD_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("D");
        }

        private void HexBtnE_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("E");
        }

        private void HexBtnF_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("F");
        }
        #endregion

        #region HEX Decimal Buttons

        private void HexDecBtn0_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("0");
        }

        private void HexDecBtn1_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("1");
        }

        private void HexDecBtn2_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("2");
        }

        private void HexDecBtn3_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("3");
        }

        private void HexDecBtn4_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("4");
        }

        private void HexDecBtn5_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("5");
        }

        private void HexDecBtn6_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("6");
        }

        private void HexDecBtn7_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("7");
        }

        private void HexDecBtn8_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("8");
        }

        private void HexDecBtn9_Click(object sender, EventArgs e)
        {
            HexInpBox.AppendText("9");
        }

        #endregion

        private void HexToIntBtn_CheckedChanged(object sender, EventArgs e)
        {
            HexInpBox.Clear();
            HexOutBox.Clear();
            foreach (Button btn in HexDecButtons)
            {
                btn.Visible = false;
            }
            foreach (Button btn in HexButtons)
            {
                btn.Visible = true;
            }
        }

        private void IntToHexBtn_CheckedChanged(object sender, EventArgs e)
        {
            HexInpBox.Clear();
            HexOutBox.Clear();
            foreach (Button btn in HexButtons)
            {
                btn.Visible = false;
            }
            foreach(Button btn in HexDecButtons)
            {
                btn.Visible = true;
            }
        }

        private void TraHexBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HexInpBox.Text))
            {
                if (HexToIntBtn.Checked)
                {
                    HexOutBox.Text = "HEX to Integer";
                }
                if(IntToHexBtn.Checked)
                {
                    HexOutBox.Text = "Integer to HEX";
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Nenhum nímero foi digitado", "Error NULL");
            }
        }

        #endregion
    }
}
