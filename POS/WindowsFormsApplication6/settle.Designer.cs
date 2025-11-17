namespace WindowsFormsApplication6
{
    partial class settle
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
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnDZero = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btntow = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSale
            // 
            this.txtSale.Enabled = false;
            this.txtSale.Location = new System.Drawing.Point(12, 13);
            this.txtSale.Multiline = true;
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(218, 26);
            this.txtSale.TabIndex = 0;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(12, 45);
            this.txtCash.Multiline = true;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(218, 26);
            this.txtCash.TabIndex = 1;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(12, 77);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(218, 26);
            this.txtChange.TabIndex = 2;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSeven.ForeColor = System.Drawing.Color.White;
            this.btnSeven.Location = new System.Drawing.Point(12, 119);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(50, 50);
            this.btnSeven.TabIndex = 3;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btneight
            // 
            this.btneight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btneight.ForeColor = System.Drawing.Color.White;
            this.btneight.Location = new System.Drawing.Point(68, 119);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(50, 50);
            this.btneight.TabIndex = 4;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = false;
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(180, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnnine
            // 
            this.btnnine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnnine.ForeColor = System.Drawing.Color.White;
            this.btnnine.Location = new System.Drawing.Point(124, 119);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(50, 50);
            this.btnnine.TabIndex = 5;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = false;
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(180, 175);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(50, 50);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSix.ForeColor = System.Drawing.Color.White;
            this.btnSix.Location = new System.Drawing.Point(124, 175);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(50, 50);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnFive.ForeColor = System.Drawing.Color.White;
            this.btnFive.Location = new System.Drawing.Point(68, 175);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(50, 50);
            this.btnFive.TabIndex = 8;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnFour.ForeColor = System.Drawing.Color.White;
            this.btnFour.Location = new System.Drawing.Point(12, 175);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(50, 50);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnDZero
            // 
            this.btnDZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnDZero.ForeColor = System.Drawing.Color.White;
            this.btnDZero.Location = new System.Drawing.Point(180, 231);
            this.btnDZero.Name = "btnDZero";
            this.btnDZero.Size = new System.Drawing.Size(50, 50);
            this.btnDZero.TabIndex = 14;
            this.btnDZero.Text = "00";
            this.btnDZero.UseVisualStyleBackColor = false;
            this.btnDZero.Click += new System.EventHandler(this.btnDZero_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Location = new System.Drawing.Point(124, 231);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(50, 50);
            this.btnThree.TabIndex = 13;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btntow
            // 
            this.btntow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btntow.ForeColor = System.Drawing.Color.White;
            this.btntow.Location = new System.Drawing.Point(68, 231);
            this.btntow.Name = "btntow";
            this.btntow.Size = new System.Drawing.Size(50, 50);
            this.btntow.TabIndex = 12;
            this.btntow.Text = "2";
            this.btntow.UseVisualStyleBackColor = false;
            this.btntow.Click += new System.EventHandler(this.btntow_Click);
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnone.ForeColor = System.Drawing.Color.White;
            this.btnone.Location = new System.Drawing.Point(12, 231);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(50, 50);
            this.btnone.TabIndex = 11;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = false;
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(12, 287);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(218, 50);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // settle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 351);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnDZero);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btntow);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtSale);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settle Payment";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settle_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnDZero;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btntow;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.TextBox txtSale;
    }
}