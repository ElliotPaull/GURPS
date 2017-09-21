using System;
using System.Windows.Forms;

namespace GuipsSheet
{
    public partial class CharacterSheetHelper : Form
    {
        public CharacterSheetHelper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 30)
            {
                numericUpDown1.Value = 1;
            }
            if (numericUpDown1.Value == 0)
            {
                numericUpDown1.Value = 30;
            }
        }
    }
}
