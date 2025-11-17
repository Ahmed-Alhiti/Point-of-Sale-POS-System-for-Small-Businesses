namespace WindowsFormsApplication6
{
    partial class CancelOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTranasNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCancelBy = new System.Windows.Forms.TextBox();
            this.txtVoidBy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbInventory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCOrder = new System.Windows.Forms.Button();
            this.udCancelQty = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(861, 47);
            this.panel1.TabIndex = 9;
            // 
            // picclose
            // 
            this.picclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picclose.Image = global::WindowsFormsApplication6.Properties.Resources.close_window_30px;
            this.picclose.Location = new System.Drawing.Point(833, -2);
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
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancel Order Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "id :";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(183, 107);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(165, 26);
            this.txtid.TabIndex = 11;
            // 
            // txtPcode
            // 
            this.txtPcode.Enabled = false;
            this.txtPcode.Location = new System.Drawing.Point(183, 139);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.Size = new System.Drawing.Size(165, 26);
            this.txtPcode.TabIndex = 12;
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(183, 171);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(165, 67);
            this.txtDesc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Qty / Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price :";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(534, 171);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(113, 26);
            this.txtQty.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(534, 139);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(290, 26);
            this.txtPrice.TabIndex = 18;
            // 
            // txtTranasNo
            // 
            this.txtTranasNo.Enabled = false;
            this.txtTranasNo.Location = new System.Drawing.Point(534, 107);
            this.txtTranasNo.Name = "txtTranasNo";
            this.txtTranasNo.Size = new System.Drawing.Size(290, 26);
            this.txtTranasNo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Transaction No :";
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Location = new System.Drawing.Point(663, 171);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(161, 26);
            this.txtDisc.TabIndex = 22;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(534, 215);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(290, 26);
            this.txtTotal.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "SOLD ITEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "CANCEL ITEM(S)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Add To Inventory ?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Cancelled By :";
            // 
            // txtCancelBy
            // 
            this.txtCancelBy.Enabled = false;
            this.txtCancelBy.Location = new System.Drawing.Point(183, 347);
            this.txtCancelBy.Name = "txtCancelBy";
            this.txtCancelBy.Size = new System.Drawing.Size(165, 26);
            this.txtCancelBy.TabIndex = 29;
            // 
            // txtVoidBy
            // 
            this.txtVoidBy.Location = new System.Drawing.Point(183, 315);
            this.txtVoidBy.Name = "txtVoidBy";
            this.txtVoidBy.Size = new System.Drawing.Size(165, 26);
            this.txtVoidBy.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Void By :";
            // 
            // cbInventory
            // 
            this.cbInventory.FormattingEnabled = true;
            this.cbInventory.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbInventory.Location = new System.Drawing.Point(183, 385);
            this.cbInventory.Name = "cbInventory";
            this.cbInventory.Size = new System.Drawing.Size(165, 28);
            this.cbInventory.TabIndex = 33;
            this.cbInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbInventory_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Reason(s) :";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(546, 353);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(278, 61);
            this.txtReason.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(405, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Cancel Qty :";
            // 
            // btnCOrder
            // 
            this.btnCOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnCOrder.FlatAppearance.BorderSize = 0;
            this.btnCOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOrder.ForeColor = System.Drawing.Color.White;
            this.btnCOrder.Location = new System.Drawing.Point(663, 437);
            this.btnCOrder.Name = "btnCOrder";
            this.btnCOrder.Size = new System.Drawing.Size(161, 28);
            this.btnCOrder.TabIndex = 38;
            this.btnCOrder.Text = "Cancel Order";
            this.btnCOrder.UseVisualStyleBackColor = false;
            this.btnCOrder.Click += new System.EventHandler(this.btnCOrder_Click);
            // 
            // udCancelQty
            // 
            this.udCancelQty.Location = new System.Drawing.Point(546, 318);
            this.udCancelQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udCancelQty.Name = "udCancelQty";
            this.udCancelQty.Size = new System.Drawing.Size(278, 26);
            this.udCancelQty.TabIndex = 39;
            this.udCancelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 477);
            this.Controls.Add(this.udCancelQty);
            this.Controls.Add(this.btnCOrder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbInventory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCancelBy);
            this.Controls.Add(this.txtVoidBy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTranasNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPcode);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CancelOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelOrder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CancelOrder_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button btnCOrder;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtPcode;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtTranasNo;
        public System.Windows.Forms.TextBox txtDisc;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtCancelBy;
        public System.Windows.Forms.NumericUpDown udCancelQty;
        public System.Windows.Forms.TextBox txtVoidBy;
        public System.Windows.Forms.ComboBox cbInventory;
        public System.Windows.Forms.TextBox txtReason;
    }
}