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
    public partial class Change_Pass_Form : Form
    {
        public Change_Pass_Form()
        {
            InitializeComponent();
        }

        private void Yes_Alert_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("X:\\Windows\\system32\\PassReset64.exe");
            Close();
        }

        private void No_Alert_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
