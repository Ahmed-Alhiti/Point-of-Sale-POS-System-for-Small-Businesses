namespace WindowsFormsApplication6
{
    partial class SupplierModule
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
            this.picclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcontactperson = new System.Windows.Forms.TextBox();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.txtemailaddress = new System.Windows.Forms.TextBox();
            this.txtfaxnumber = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picclose
            // 
            this.picclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picclose.Image = global::WindowsFormsApplication6.Properties.Resources.close_window_30px;
            this.picclose.Location = new System.Drawing.Point(690, -2);
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
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Module";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.picclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 47);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Supplier Name:";
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(145, 81);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(549, 26);
            this.txtsuppliername.TabIndex = 31;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(604, 301);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 28);
            this.btncancel.TabIndex = 34;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(504, 301);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 28);
            this.btnupdate.TabIndex = 33;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(408, 301);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 28);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Contact Person :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Phone-No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "E-mail Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fax-No :";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(145, 125);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(549, 26);
            this.txtaddress.TabIndex = 40;
            // 
            // txtcontactperson
            // 
            this.txtcontactperson.Location = new System.Drawing.Point(145, 169);
            this.txtcontactperson.Name = "txtcontactperson";
            this.txtcontactperson.Size = new System.Drawing.Size(549, 26);
            this.txtcontactperson.TabIndex = 41;
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Location = new System.Drawing.Point(145, 213);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(230, 26);
            this.txtphoneNumber.TabIndex = 42;
            // 
            // txtemailaddress
            // 
            this.txtemailaddress.Location = new System.Drawing.Point(145, 257);
            this.txtemailaddress.Name = "txtemailaddress";
            this.txtemailaddress.Size = new System.Drawing.Size(549, 26);
            this.txtemailaddress.TabIndex = 43;
            // 
            // txtfaxnumber
            // 
            this.txtfaxnumber.Location = new System.Drawing.Point(452, 213);
            this.txtfaxnumber.Name = "txtfaxnumber";
            this.txtfaxnumber.Size = new System.Drawing.Size(242, 26);
            this.txtfaxnumber.TabIndex = 45;
            // 
            // labelid
            // 
            this.labelid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(11, 328);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(22, 20);
            this.labelid.TabIndex = 46;
            this.labelid.Text = "id";
            this.labelid.Visible = false;
            // 
            // SupplierModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 357);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.txtfaxnumber);
            this.Controls.Add(this.txtemailaddress);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.txtcontactperson);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsuppliername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SupplierModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierModule";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupplierModule_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtsuppliername;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.TextBox txtcontactperson;
        public System.Windows.Forms.TextBox txtphoneNumber;
        public System.Windows.Forms.TextBox txtemailaddress;
        public System.Windows.Forms.TextBox txtfaxnumber;
        public System.Windows.Forms.Label labelid;
    }
}