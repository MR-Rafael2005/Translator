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
using ConBinHexOct;

namespace Translator
{
    public partial class TranslatorPage : Form
    { 
        public TranslatorPage()
        {
            InitializeComponent();
        }

        /*private void transBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Converter.ConvertBinToInt(inpTBox.Text) == null)
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Número inválido", "Erro de número");
                }
                else
                {
                    outTBox.Text = Converter.ConvertBinToInt(inpTBox.Text);
                }
            }
            catch (Exception)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Número inválido", "Erro de número");
            }
        }*/
    }
}
