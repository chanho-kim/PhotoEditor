using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class flipDialog : Form
    {
        public int result = 0;

        public flipDialog()
        {
            InitializeComponent();
            result = 0;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (overX.Checked == true) result = 1;
            else if (overY.Checked == true) result = 2;
            else result = 0;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            result = 0;
            this.Close();
        }
    }
}
