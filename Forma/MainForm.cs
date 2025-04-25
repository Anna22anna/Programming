using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class MainForm : Form
    {
        supportform supportForm;
        public MainForm()
        {
            InitializeComponent();

        }
        private void OpenButton_Click_1(object sender, EventArgs e)
        {
            supportForm = new supportform();
            supportForm.Show();

        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            supportForm.Close();
        }

        private void DialogeButton_Click(object sender, EventArgs e)
        {
            var result = supportForm.ShowDialog;
        }
    }
}
