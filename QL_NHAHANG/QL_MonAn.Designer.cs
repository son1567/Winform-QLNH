namespace QL_NHAHANG
{
    partial class QL_MonAn
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
            this.cmb_dmma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenmonan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.table_monan = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dg = new System.Windows.Forms.TextBox();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.cmb_loai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_monan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_dmma
            // 
            this.cmb_dmma.FormattingEnabled = true;
            this.cmb_dmma.Location = new System.Drawing.Point(255, 42);
            this.cmb_dmma.Name = "cmb_dmma";
            this.cmb_dmma.Size = new System.Drawing.Size(183, 24);
            this.cmb_dmma.TabIndex = 0;
            this.cmb_dmma.SelectedIndexChanged += new System.EventHandler(this.cmb_dmma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục món ăn";
            // 
            // txt_tenmonan
            // 
            this.txt_tenmonan.Location = new System.Drawing.Point(255, 84);
            this.txt_tenmonan.Name = "txt_tenmonan";
            this.txt_tenmonan.Size = new System.Drawing.Size(183, 22);
            this.txt_tenmonan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên món ăn";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(501, 79);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(81, 27);
            this.btn_timkiem.TabIndex = 4;
            this.btn_timkiem.Text = "TÌm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // table_monan
            // 
            this.table_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_monan.Location = new System.Drawing.Point(12, 138);
            this.table_monan.Name = "table_monan";
            this.table_monan.RowTemplate.Height = 24;
            this.table_monan.Size = new System.Drawing.Size(703, 374);
            this.table_monan.TabIndex = 5;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(814, 471);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(89, 41);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(998, 471);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(89, 41);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(1162, 471);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(89, 41);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(598, 584);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(89, 41);
            this.btn_dong.TabIndex = 9;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã món ăn";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(952, 133);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(183, 22);
            this.txt_ma.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại món ăn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(811, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Đơn giá";
            // 
            // txt_dg
            // 
            this.txt_dg.Location = new System.Drawing.Point(952, 398);
            this.txt_dg.Name = "txt_dg";
            this.txt_dg.Size = new System.Drawing.Size(183, 22);
            this.txt_dg.TabIndex = 16;
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(952, 333);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(183, 22);
            this.txt_dvt.TabIndex = 17;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(952, 204);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(183, 22);
            this.txt_ten.TabIndex = 19;
            // 
            // cmb_loai
            // 
            this.cmb_loai.FormattingEnabled = true;
            this.cmb_loai.Location = new System.Drawing.Point(952, 269);
            this.cmb_loai.Name = "cmb_loai";
            this.cmb_loai.Size = new System.Drawing.Size(183, 24);
            this.cmb_loai.TabIndex = 20;
            // 
            // QL_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 673);
            this.Controls.Add(this.cmb_loai);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.txt_dg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.table_monan);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenmonan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_dmma);
            this.Name = "QL_MonAn";
            this.Text = "QL_MonAn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QL_MonAn_FormClosing);
            this.Load += new System.EventHandler(this.QL_MonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_monan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_dmma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenmonan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridView table_monan;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dg;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.ComboBox cmb_loai;
    }
}