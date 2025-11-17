namespace WindowsFormsApplication6
{
    partial class UserAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.btnAccsave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnPassCancel = new System.Windows.Forms.Button();
            this.btnPassSave = new System.Windows.Forms.Button();
            this.txtRePass2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCurPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.gbuser = new System.Windows.Forms.GroupBox();
            this.btnRestPass = new System.Windows.Forms.Button();
            this.lblAccountnote = new System.Windows.Forms.Label();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnReomve = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.gbuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 89);
            this.panel1.TabIndex = 1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(43, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(894, 454);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.btnAccCancel);
            this.metroTabPage1.Controls.Add(this.btnAccsave);
            this.metroTabPage1.Controls.Add(this.txtName);
            this.metroTabPage1.Controls.Add(this.cbRole);
            this.metroTabPage1.Controls.Add(this.txtRePass);
            this.metroTabPage1.Controls.Add(this.txtPassword);
            this.metroTabPage1.Controls.Add(this.txtUsername);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(886, 412);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Create Account";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 1;
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.FlatAppearance.BorderSize = 0;
            this.btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAccCancel.Location = new System.Drawing.Point(708, 335);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(90, 28);
            this.btnAccCancel.TabIndex = 13;
            this.btnAccCancel.Text = "Cancel";
            this.btnAccCancel.UseVisualStyleBackColor = false;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // btnAccsave
            // 
            this.btnAccsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnAccsave.FlatAppearance.BorderSize = 0;
            this.btnAccsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccsave.ForeColor = System.Drawing.Color.White;
            this.btnAccsave.Location = new System.Drawing.Point(595, 335);
            this.btnAccsave.Name = "btnAccsave";
            this.btnAccsave.Size = new System.Drawing.Size(90, 28);
            this.btnAccsave.TabIndex = 12;
            this.btnAccsave.Text = "Save";
            this.btnAccsave.UseVisualStyleBackColor = false;
            this.btnAccsave.Click += new System.EventHandler(this.btnAccsave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(276, 259);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(522, 26);
            this.txtName.TabIndex = 11;
            // 
            // cbRole
            // 
            this.cbRole.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrator",
            "Cashier\t\t\t"});
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            this.cbRole.Location = new System.Drawing.Point(276, 208);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(522, 28);
            this.cbRole.TabIndex = 10;
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(276, 159);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(522, 26);
            this.txtRePass.TabIndex = 9;
            this.txtRePass.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(276, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(522, 26);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(276, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(522, 26);
            this.txtUsername.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ful Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Role :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-typ Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.lblUsername);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.Controls.Add(this.btnPassCancel);
            this.metroTabPage2.Controls.Add(this.btnPassSave);
            this.metroTabPage2.Controls.Add(this.txtRePass2);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.txtNewPass);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.txtCurPassword);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(886, 412);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Change Password";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(138, 63);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 18);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // btnPassCancel
            // 
            this.btnPassCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.FlatAppearance.BorderSize = 0;
            this.btnPassCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassCancel.ForeColor = System.Drawing.Color.Black;
            this.btnPassCancel.Location = new System.Drawing.Point(679, 326);
            this.btnPassCancel.Name = "btnPassCancel";
            this.btnPassCancel.Size = new System.Drawing.Size(90, 28);
            this.btnPassCancel.TabIndex = 17;
            this.btnPassCancel.Text = "Cancel";
            this.btnPassCancel.UseVisualStyleBackColor = false;
            this.btnPassCancel.Click += new System.EventHandler(this.btnPassCancel_Click);
            // 
            // btnPassSave
            // 
            this.btnPassSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnPassSave.FlatAppearance.BorderSize = 0;
            this.btnPassSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassSave.ForeColor = System.Drawing.Color.White;
            this.btnPassSave.Location = new System.Drawing.Point(566, 326);
            this.btnPassSave.Name = "btnPassSave";
            this.btnPassSave.Size = new System.Drawing.Size(90, 28);
            this.btnPassSave.TabIndex = 16;
            this.btnPassSave.Text = "Save";
            this.btnPassSave.UseVisualStyleBackColor = false;
            this.btnPassSave.Click += new System.EventHandler(this.btnPassSave_Click);
            // 
            // txtRePass2
            // 
            this.txtRePass2.Location = new System.Drawing.Point(247, 263);
            this.txtRePass2.Name = "txtRePass2";
            this.txtRePass2.Size = new System.Drawing.Size(522, 26);
            this.txtRePass2.TabIndex = 15;
            this.txtRePass2.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Re-type Password :";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(247, 194);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(522, 26);
            this.txtNewPass.TabIndex = 13;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "New Password :";
            // 
            // txtCurPassword
            // 
            this.txtCurPassword.Location = new System.Drawing.Point(247, 125);
            this.txtCurPassword.Name = "txtCurPassword";
            this.txtCurPassword.Size = new System.Drawing.Size(522, 26);
            this.txtCurPassword.TabIndex = 11;
            this.txtCurPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Current Password :";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.gbuser);
            this.metroTabPage3.Controls.Add(this.btnProperties);
            this.metroTabPage3.Controls.Add(this.btnReomve);
            this.metroTabPage3.Controls.Add(this.dgvUser);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 1;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(886, 412);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Active/UnActive Account";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 1;
            // 
            // gbuser
            // 
            this.gbuser.BackColor = System.Drawing.Color.White;
            this.gbuser.Controls.Add(this.btnRestPass);
            this.gbuser.Controls.Add(this.pictureBox2);
            this.gbuser.Controls.Add(this.lblAccountnote);
            this.gbuser.Location = new System.Drawing.Point(12, 318);
            this.gbuser.Name = "gbuser";
            this.gbuser.Size = new System.Drawing.Size(861, 91);
            this.gbuser.TabIndex = 19;
            this.gbuser.TabStop = false;
            this.gbuser.Text = "Password For UserName ";
            // 
            // btnRestPass
            // 
            this.btnRestPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestPass.BackColor = System.Drawing.Color.Silver;
            this.btnRestPass.FlatAppearance.BorderSize = 0;
            this.btnRestPass.ForeColor = System.Drawing.Color.Black;
            this.btnRestPass.Location = new System.Drawing.Point(629, 57);
            this.btnRestPass.Name = "btnRestPass";
            this.btnRestPass.Size = new System.Drawing.Size(226, 28);
            this.btnRestPass.TabIndex = 18;
            this.btnRestPass.Text = "Reset Password ...";
            this.btnRestPass.UseVisualStyleBackColor = false;
            this.btnRestPass.Click += new System.EventHandler(this.btnRestPass_Click);
            // 
            // lblAccountnote
            // 
            this.lblAccountnote.AutoSize = true;
            this.lblAccountnote.Location = new System.Drawing.Point(98, 22);
            this.lblAccountnote.Name = "lblAccountnote";
            this.lblAccountnote.Size = new System.Drawing.Size(453, 20);
            this.lblAccountnote.TabIndex = 0;
            this.lblAccountnote.Text = "To change the password for username . click Reset Password";
            // 
            // btnProperties
            // 
            this.btnProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProperties.BackColor = System.Drawing.Color.Silver;
            this.btnProperties.FlatAppearance.BorderSize = 0;
            this.btnProperties.ForeColor = System.Drawing.Color.Black;
            this.btnProperties.Location = new System.Drawing.Point(760, 272);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(113, 28);
            this.btnProperties.TabIndex = 18;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnReomve
            // 
            this.btnReomve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReomve.BackColor = System.Drawing.Color.Silver;
            this.btnReomve.FlatAppearance.BorderSize = 0;
            this.btnReomve.ForeColor = System.Drawing.Color.Black;
            this.btnReomve.Location = new System.Drawing.Point(641, 272);
            this.btnReomve.Name = "btnReomve";
            this.btnReomve.Size = new System.Drawing.Size(113, 28);
            this.btnReomve.TabIndex = 17;
            this.btnReomve.Text = "Remove";
            this.btnReomve.UseVisualStyleBackColor = false;
            this.btnReomve.Click += new System.EventHandler(this.btnReomve_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeight = 30;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(12, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.Size = new System.Drawing.Size(861, 266);
            this.dgvUser.TabIndex = 2;
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "User Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 112;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Full Name";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Account Activate";
            this.Column5.Name = "Column5";
            this.Column5.Width = 164;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Role";
            this.Column4.Name = "Column4";
            this.Column4.Width = 64;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(415, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(271, 33);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search here ...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(445, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here ...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::WindowsFormsApplication6.Properties.Resources.admin_settings_male_30px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Setting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApplication6.Properties.Resources.edit_20px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::WindowsFormsApplication6.Properties.Resources.delete_20px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.gbuser.ResumeLayout(false);
            this.gbuser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Button btnAccCancel;
        public System.Windows.Forms.Button btnAccsave;
        public System.Windows.Forms.Button btnPassCancel;
        public System.Windows.Forms.Button btnPassSave;
        private System.Windows.Forms.TextBox txtRePass2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbuser;
        public System.Windows.Forms.Button btnRestPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAccountnote;
        public System.Windows.Forms.Button btnProperties;
        public System.Windows.Forms.Button btnReomve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}