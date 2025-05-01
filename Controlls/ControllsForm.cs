using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlls
{
    public partial class ControllsForm : Form
    {
        int pictureNumber = 1;
        ResourceManager rn = new 
        public ControllsForm()
        {
            InitializeComponent();
            CaptionListBox.Items.Add("Заголовок");
            CaptionListBox.Items.Add("Глава");
            CaptionListBox.Items.Add("Параграф");

            CaptionListBox.SelectedItem = 0;

            comboBox1.Items.Add("Microsoft Sans Serif");
            comboBox1.Items.Add("New Times Roman");
            comboBox1.Items.Add("Candara");

            

            pictureBox1.ImageLocation = "prr1.jpg";
            pictureBox1.Load();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Title.Text = inputTextBox.Text;
            inputTextBox.Text = string.Empty;
        }
        private void ChangeFontStyle(object sender, EventArgs e)
        {
            var fontstyle = FontStyle.Regular;

            if (BoldCheckBox.Checked)
            {
                fontstyle |= FontStyle.Bold;

            }
            if (ItelicCheckBox.Checked)
            {
                fontstyle |= FontStyle.Italic;

            }

            if (UnderlineCheckBox.Checked)
            {
                fontstyle |= FontStyle.Underline;

            }

            Title.Font = new Font(Title.Font, fontstyle);
        }

        private void ChangeFontSize (object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                int size = int.Parse(radioButton.Text.Split()[0]);

            Title.Font = new Font(Title.Font.FontFamily, size);
            }
        }

        private void CaptionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Title.Text = CaptionListBox.SelectedIndex.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ChangePicture(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                if (button.Text == "<")
                {
                    pictureNumber--;
                }
                else 
                    pictureNumber++;

                if (pictureNumber == 0)
                    pictureNumber = 7;
                else if (pictureNumber == 8)
                    pictureNumber = 1;

                pictureBox1.Image = rn.GetObject
            }
        }
    }
}
