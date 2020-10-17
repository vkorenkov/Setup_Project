namespace WindowsFormsApp3
{
    partial class Manual_Allert_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual_Allert_Form));
            this.Manual_Allert_Label = new System.Windows.Forms.Label();
            this.Yes_Alert_Button = new System.Windows.Forms.Button();
            this.No_Alert_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Manual_Allert_Label
            // 
            this.Manual_Allert_Label.AutoSize = true;
            this.Manual_Allert_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Manual_Allert_Label.Location = new System.Drawing.Point(41, 9);
            this.Manual_Allert_Label.Name = "Manual_Allert_Label";
            this.Manual_Allert_Label.Size = new System.Drawing.Size(219, 104);
            this.Manual_Allert_Label.TabIndex = 0;
            this.Manual_Allert_Label.Text = resources.GetString("Manual_Allert_Label.Text");
            // 
            // Yes_Alert_Button
            // 
            this.Yes_Alert_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.Yes_Alert_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yes_Alert_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Yes_Alert_Button.Location = new System.Drawing.Point(44, 119);
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
            this.No_Alert_Button.Location = new System.Drawing.Point(150, 119);
            this.No_Alert_Button.Name = "No_Alert_Button";
            this.No_Alert_Button.Size = new System.Drawing.Size(90, 30);
            this.No_Alert_Button.TabIndex = 11;
            this.No_Alert_Button.Text = "Нет";
            this.No_Alert_Button.UseVisualStyleBackColor = false;
            this.No_Alert_Button.Click += new System.EventHandler(this.No_Alert_Button_Click);
            // 
            // Manual_Allert_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.No_Alert_Button);
            this.Controls.Add(this.Yes_Alert_Button);
            this.Controls.Add(this.Manual_Allert_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manual_Allert_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предупреждение";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Manual_Allert_Label;
        private System.Windows.Forms.Button Yes_Alert_Button;
        private System.Windows.Forms.Button No_Alert_Button;
    }
}