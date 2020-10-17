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
    public partial class Joke : Form
    {
        private Label Joke_Label;
        private Button button1;

        public Joke()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Joke_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Joke_Label
            // 
            this.Joke_Label.AutoSize = true;
            this.Joke_Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Joke_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Joke_Label.Location = new System.Drawing.Point(12, 9);
            this.Joke_Label.Name = "Joke_Label";
            this.Joke_Label.Size = new System.Drawing.Size(266, 52);
            this.Joke_Label.TabIndex = 0;
            this.Joke_Label.Text = "                     Зачем ты нажал здесь? \r\nТы запустил форматирование системног" +
    "о диска...\r\n\r\n                Ладно, это шутка! Расслабься =)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(106, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "WAT?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Joke
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Joke_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Joke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Powershell.exe");
            Close();
        }
    }
}
