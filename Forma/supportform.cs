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
    public partial class supportform : Form
    {
        public supportform()
        {
            InitializeComponent();
        }

        private void supportform_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void supportform_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
