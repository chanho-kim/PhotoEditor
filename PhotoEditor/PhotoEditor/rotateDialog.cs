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
    public partial class rotateDialog : Form
    {
        public int result = 0;

        public rotateDialog()
        {
            InitializeComponent();
            result = 0;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (ninetyDeg.Checked)
            {
                result = 1;
            }
            else if (oneEightyDegree.Checked)
            {
                result = 2;
            }
            else if (twoSeventyDegree.Checked)
            {
                result = 3;
            }
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
