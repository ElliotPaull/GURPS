using System;
using System.Windows.Forms;
using System.IO;

namespace GuipsSheet
{
    public partial class CharacterSheetHelper : Form
    {
        private Legality legality = new Legality();
        string charactersDirectory = "Characters";
        
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
        
        private void strengthUpDown_ValueChanged(object sender, EventArgs e)
        {
            strengthUpDown.Value = Wrap30((int)strengthUpDown.Value);
        }

        private void dexterityUpDown_ValueChanged(object sender, EventArgs e)
        {
           dexterityUpDown.Value = Wrap30((int)dexterityUpDown.Value);
        }

        private void intelligenceUpDown_ValueChanged(object sender, EventArgs e)
        {
            intelligenceUpDown.Value = Wrap30((int)intelligenceUpDown.Value);
        }
        private void healthUpDown_ValueChanged(object sender, EventArgs e)
        {
            healthUpDown.Value = Wrap30((int)healthUpDown.Value);
        }

        private int Wrap30(int attributeValue)
        {
            if (attributeValue > 30)
            {
                return 1;
            }

            if (attributeValue == 0)
            {
                return 30;
            }

            return attributeValue;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var name = nameInput.Text;
            if (!Directory.Exists(charactersDirectory))
                Directory.CreateDirectory(charactersDirectory);
            using (var fileStream = new FileStream(charactersDirectory + "/" + name + ".txt", FileMode.OpenOrCreate))
            {
                legality.SaveCharacter(fileStream, name);
            }
        }
    }
}
