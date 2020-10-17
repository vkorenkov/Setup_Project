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
    public partial class Autoinstall_Allert_Form : Form
    {
        private const string FileName = "cmd";

        public Autoinstall_Allert_Form()
        {
            InitializeComponent();
        }

        private void Autoinstall_Alert_Form_Load(object sender, EventArgs e)
        {

        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void No_Alert_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Yes_Alert_Button_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("Cmd", "/k X:\\sources\\setup.exe /unattend:X:\\windows\\system32\\Unattend.xml");
            Close();
        }
    }
}
