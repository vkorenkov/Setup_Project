namespace WindowsFormsApp3
{
    partial class Change_Pass_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Change_Pass_Labbel = new System.Windows.Forms.Label();
            this.Yes_Alert_Button = new System.Windows.Forms.Button();
            this.No_Alert_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Change_Pass_Labbel
            // 
            this.Change_Pass_Labbel.AutoSize = true;
            this.Change_Pass_Labbel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Change_Pass_Labbel.Location = new System.Drawing.Point(66, 9);
            this.Change_Pass_Labbel.Name = "Change_Pass_Labbel";
            this.Change_Pass_Labbel.Size = new System.Drawing.Size(181, 104);
            this.Change_Pass_Labbel.TabIndex = 0;
            this.Change_Pass_Labbel.Text = "Сброс пароля выбранного \r\nлокального пользователя.\r\n(Данная программа именно\r\nсбр" +
    "асывает пароль пользователя\r\nА не меняет его, не забудте \r\nназначить новый парол" +
    "ь.)\r\n\r\n           продолжить?";
            // 
            // Yes_Alert_Button
            // 
            this.Yes_Alert_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.Yes_Alert_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yes_Alert_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Yes_Alert_Button.Location = new System.Drawing.Point(42, 126);
            this.Yes_Alert_Button.Name = "Yes_Alert_Button";
            this.Yes_Alert_Button.Size = new System.Drawing.Size(90, 30);
            this.Yes_Alert_Button.TabIndex = 10;
            this.Yes_Alert_Button.Text = "Да";
            this.Yes_Alert_Button.UseVisualStyleBackColor = false;
            this.Yes_Alert_Button.Click += new System.EventHandler(this.Yes_Alert_Button_Click);
            // 
            // No_Alert_Button
            // 
            this.No_Alert_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.No_Alert_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.No_Alert_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.No_Alert_Button.Location = new System.Drawing.Point(148, 126);
            this.No_Alert_Button.Name = "No_Alert_Button";
            this.No_Alert_Button.Size = new System.Drawing.Size(90, 30);
            this.No_Alert_Button.TabIndex = 11;
            this.No_Alert_Button.Text = "Нет";
            this.No_Alert_Button.UseVisualStyleBackColor = false;
            this.No_Alert_Button.Click += new System.EventHandler(this.No_Alert_Button_Click);
            // 
            // Change_Pass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.No_Alert_Button);
            this.Controls.Add(this.Yes_Alert_Button);
            this.Controls.Add(this.Change_Pass_Labbel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change_Pass_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предупреждение";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Change_Pass_Labbel;
        private System.Windows.Forms.Button Yes_Alert_Button;
        private System.Windows.Forms.Button No_Alert_Button;
    }
}