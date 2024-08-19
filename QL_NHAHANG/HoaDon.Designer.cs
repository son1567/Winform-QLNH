namespace QL_NHAHANG
{
    partial class HoaDon
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
            this.btn_tim = new System.Windows.Forms.Button();
            this.cbo_nam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_thang = new System.Windows.Forms.ComboBox();
            this.btn_xct = new System.Windows.Forms.Button();
            this.table_hoadon = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_tt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.table_cthd = new System.Windows.Forms.DataGridView();
            this.btn_dong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_hoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_cthd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.cbo_nam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_thang);
            this.groupBox1.Controls.Add(this.btn_xct);
            this.groupBox1.Controls.Add(this.table_hoadon);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(457, 14);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(117, 36);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // cbo_nam
            // 
            this.cbo_nam.FormattingEnabled = true;
            this.cbo_nam.Location = new System.Drawing.Point(299, 26);
            this.cbo_nam.Name = "cbo_nam";
            this.cbo_nam.Size = new System.Drawing.Size(68, 24);
            this.cbo_nam.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng";
            // 
            // cbo_thang
            // 
            this.cbo_thang.FormattingEnabled = true;
            this.cbo_thang.Location = new System.Drawing.Point(96, 26);
            this.cbo_thang.Name = "cbo_thang";
            this.cbo_thang.Size = new System.Drawing.Size(68, 24);
            this.cbo_thang.TabIndex = 5;
            // 
            // btn_xct
            // 
            this.btn_xct.Location = new System.Drawing.Point(499, 233);
            this.btn_xct.Name = "btn_xct";
            this.btn_xct.Size = new System.Drawing.Size(75, 36);
            this.btn_xct.TabIndex = 4;
            this.btn_xct.Text = "Chi tiết";
            this.btn_xct.UseVisualStyleBackColor = true;
            this.btn_xct.Click += new System.EventHandler(this.btn_xct_Click);
            // 
            // table_hoadon
            // 
            this.table_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_hoadon.Location = new System.Drawing.Point(35, 56);
            this.table_hoadon.Name = "table_hoadon";
            this.table_hoadon.RowTemplate.Height = 24;
            this.table_hoadon.Size = new System.Drawing.Size(722, 170);
            this.table_hoadon.TabIndex = 0;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(227, 232);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 37);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_tt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.table_cthd);
            this.groupBox2.Location = new System.Drawing.Point(826, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tt.ForeColor = System.Drawing.Color.Red;
            this.lb_tt.Location = new System.Drawing.Point(269, 206);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(82, 17);
            this.lb_tt.TabIndex = 2;
            this.lb_tt.Text = "Tổng tiền ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền ";
            // 
            // table_cthd
            // 
            this.table_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_cthd.Location = new System.Drawing.Point(37, 41);
            this.table_cthd.Name = "table_cthd";
            this.table_cthd.RowTemplate.Height = 24;
            this.table_cthd.Size = new System.Drawing.Size(484, 150);
            this.table_cthd.TabIndex = 0;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(677, 415);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 36);
            this.btn_dong.TabIndex = 3;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 497);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDon";
            this.Text = "Chi tiết hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDon_FormClosing);
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_hoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_cthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_thang;
        private System.Windows.Forms.Button btn_xct;
        private System.Windows.Forms.DataGridView table_hoadon;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_tt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table_cthd;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_tim;

    }
}