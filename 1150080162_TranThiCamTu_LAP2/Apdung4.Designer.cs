namespace _1150080162_TranThiCamTu_LAP2
{
    partial class Apdung4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDaChon = new System.Windows.Forms.ListBox();
            this.btnChuyen1 = new System.Windows.Forms.Button();
            this.btnChuyenHet1 = new System.Windows.Forms.Button();
            this.btnChuyen1Nguoc = new System.Windows.Forms.Button();
            this.btnChuyenHet1Nguoc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstMatHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các mặt hàng";
            // 
            // lstMatHang
            // 
            this.lstMatHang.FormattingEnabled = true;
            this.lstMatHang.ItemHeight = 30;
            this.lstMatHang.Items.AddRange(new object[] {
            "CPU",
            "Mainboard",
            "RAM",
            "Keyboard",
            "Mouse",
            "NIC",
            "FAN"});
            this.lstMatHang.Location = new System.Drawing.Point(22, 52);
            this.lstMatHang.Name = "lstMatHang";
            this.lstMatHang.Size = new System.Drawing.Size(378, 424);
            this.lstMatHang.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDaChon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 493);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các mặt hàng lựa chọn:";
            // 
            // lstDaChon
            // 
            this.lstDaChon.FormattingEnabled = true;
            this.lstDaChon.ItemHeight = 30;
            this.lstDaChon.Location = new System.Drawing.Point(19, 34);
            this.lstDaChon.Name = "lstDaChon";
            this.lstDaChon.Size = new System.Drawing.Size(378, 424);
            this.lstDaChon.TabIndex = 1;
            this.lstDaChon.SelectedIndexChanged += new System.EventHandler(this.lstDaChon_SelectedIndexChanged);
            // 
            // btnChuyen1
            // 
            this.btnChuyen1.Location = new System.Drawing.Point(447, 162);
            this.btnChuyen1.Name = "btnChuyen1";
            this.btnChuyen1.Size = new System.Drawing.Size(43, 45);
            this.btnChuyen1.TabIndex = 2;
            this.btnChuyen1.Text = ">";
            this.btnChuyen1.UseVisualStyleBackColor = true;
            this.btnChuyen1.Click += new System.EventHandler(this.btnChuyen1_Click);
            // 
            // btnChuyenHet1
            // 
            this.btnChuyenHet1.Location = new System.Drawing.Point(447, 222);
            this.btnChuyenHet1.Name = "btnChuyenHet1";
            this.btnChuyenHet1.Size = new System.Drawing.Size(43, 45);
            this.btnChuyenHet1.TabIndex = 3;
            this.btnChuyenHet1.Text = ">>";
            this.btnChuyenHet1.UseVisualStyleBackColor = true;
            this.btnChuyenHet1.Click += new System.EventHandler(this.btnChuyenHet1_Click);
            // 
            // btnChuyen1Nguoc
            // 
            this.btnChuyen1Nguoc.Location = new System.Drawing.Point(447, 288);
            this.btnChuyen1Nguoc.Name = "btnChuyen1Nguoc";
            this.btnChuyen1Nguoc.Size = new System.Drawing.Size(43, 45);
            this.btnChuyen1Nguoc.TabIndex = 4;
            this.btnChuyen1Nguoc.Text = "<";
            this.btnChuyen1Nguoc.UseVisualStyleBackColor = true;
            this.btnChuyen1Nguoc.Click += new System.EventHandler(this.btnChuyen1Nguoc_Click);
            // 
            // btnChuyenHet1Nguoc
            // 
            this.btnChuyenHet1Nguoc.Location = new System.Drawing.Point(447, 359);
            this.btnChuyenHet1Nguoc.Name = "btnChuyenHet1Nguoc";
            this.btnChuyenHet1Nguoc.Size = new System.Drawing.Size(43, 45);
            this.btnChuyenHet1Nguoc.TabIndex = 5;
            this.btnChuyenHet1Nguoc.Text = "<<";
            this.btnChuyenHet1Nguoc.UseVisualStyleBackColor = true;
            this.btnChuyenHet1Nguoc.Click += new System.EventHandler(this.btnChuyenHet1Nguoc_Click);
            // 
            // Apdung4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 695);
            this.Controls.Add(this.btnChuyenHet1Nguoc);
            this.Controls.Add(this.btnChuyen1Nguoc);
            this.Controls.Add(this.btnChuyenHet1);
            this.Controls.Add(this.btnChuyen1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Apdung4";
            this.Text = "Apdung4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstMatHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDaChon;
        private System.Windows.Forms.Button btnChuyen1;
        private System.Windows.Forms.Button btnChuyenHet1;
        private System.Windows.Forms.Button btnChuyen1Nguoc;
        private System.Windows.Forms.Button btnChuyenHet1Nguoc;
    }
}