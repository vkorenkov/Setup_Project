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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Autoinstall_Button_Click(object sender, EventArgs e)
        {
            Autoinstall_Allert_Form _Autoinstall_Alert_Form = new Autoinstall_Allert_Form();
            _Autoinstall_Alert_Form.Show();
        }

        private void Manual_install_button_Click(object sender, EventArgs e)
        {
            Manual_Allert_Form _Manual_Allert_Form = new Manual_Allert_Form();
            _Manual_Allert_Form.Show();
        }

        private void Dart_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("X:\\sources\\recovery\\tools\\MSDartTools.exe");
        }

        private void Password_Button_Click(object sender, EventArgs e)
        {
            Change_Pass_Form _Change_Pass_Form = new Change_Pass_Form();
            _Change_Pass_Form.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wpeutil", "shutdown");
        }

        private void Explorer_Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe");
        }

        private void Joke_Button_Click(object sender, EventArgs e)
        {
            Joke _Joke = new Joke();
            _Joke.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wpeutil", "reboot");
        }
    }
}
