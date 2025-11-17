namespace WindowsFormsApplication6
{
    partial class Void
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Void));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.btnvoid = new System.Windows.Forms.Button();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.picclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 47);
            this.panel1.TabIndex = 10;
            // 
            // picclose
            // 
            this.picclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picclose.Image = global::WindowsFormsApplication6.Properties.Resources.close_window_30px;
            this.picclose.Location = new System.Drawing.Point(378, -2);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(29, 35);
            this.picclose.TabIndex = 1;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Void Cancel Order";
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.DisplayIcon = true;
            this.txtusername.Icon = ((System.Drawing.Image)(resources.GetObject("txtusername.Icon")));
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(63, 63);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PromptText = "Username";
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(250, 27);
            this.txtusername.TabIndex = 13;
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMark = "Username";
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnvoid
            // 
            this.btnvoid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnvoid.FlatAppearance.BorderSize = 0;
            this.btnvoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoid.ForeColor = System.Drawing.Color.White;
            this.btnvoid.Location = new System.Drawing.Point(63, 172);
            this.btnvoid.Name = "btnvoid";
            this.btnvoid.Size = new System.Drawing.Size(250, 27);
            this.btnvoid.TabIndex = 15;
            this.btnvoid.Text = "Void";
            this.btnvoid.UseVisualStyleBackColor = false;
            this.btnvoid.Click += new System.EventHandler(this.btnvoid_Click);
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.CustomButton.Image = null;
            this.txtpass.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txtpass.CustomButton.Name = "";
            this.txtpass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpass.CustomButton.TabIndex = 1;
            this.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpass.CustomButton.UseSelectable = true;
            this.txtpass.CustomButton.Visible = false;
            this.txtpass.DisplayIcon = true;
            this.txtpass.Icon = ((System.Drawing.Image)(resources.GetObject("txtpass.Icon")));
            this.txtpass.Lines = new string[0];
            this.txtpass.Location = new System.Drawing.Point(63, 116);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '●';
            this.txtpass.PromptText = "Password";
            this.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(250, 27);
            this.txtpass.TabIndex = 16;
            this.txtpass.UseSelectable = true;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.WaterMark = "Password";
            this.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Void
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 211);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnvoid);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Void";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Void";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Void_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnvoid;
        private MetroFramework.Controls.MetroTextBox txtpass;
        public MetroFramework.Controls.MetroTextBox txtusername;
    }
}