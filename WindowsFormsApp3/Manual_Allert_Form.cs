using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Manual_Allert_Form : Form
    {
        public Manual_Allert_Form()
        {
            InitializeComponent();
        }

        private void Yes_Alert_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("X:\\sources\\setup.exe");
            Close();
        }

        private void No_Alert_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
