namespace QL_NHAHANG
{
    partial class HangHoa
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
            this.cbo_lhh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.table_hh = new System.Windows.Forms.DataGridView();
            this.btn_dong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_ncc = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_hh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_lhh
            // 
            this.cbo_lhh.FormattingEnabled = true;
            this.cbo_lhh.Location = new System.Drawing.Point(258, 77);
            this.cbo_lhh.Name = "cbo_lhh";
            this.cbo_lhh.Size = new System.Drawing.Size(121, 24);
            this.cbo_lhh.TabIndex = 0;
            this.cbo_lhh.SelectedIndexChanged += new System.EventHandler(this.cbo_lhh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại hàng hóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.table_hh);
            this.groupBox1.Location = new System.Drawing.Point(122, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng hóa";
            // 
            // table_hh
            // 
            this.table_hh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_hh.Location = new System.Drawing.Point(96, 44);
            this.table_hh.Name = "table_hh";
            this.table_hh.RowTemplate.Height = 24;
            this.table_hh.Size = new System.Drawing.Size(619, 150);
            this.table_hh.TabIndex = 0;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(460, 412);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 33);
            this.btn_dong.TabIndex = 3;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhà cung cấp";
            // 
            // cbo_ncc
            // 
            this.cbo_ncc.FormattingEnabled = true;
            this.cbo_ncc.Location = new System.Drawing.Point(556, 77);
            this.cbo_ncc.Name = "cbo_ncc";
            this.cbo_ncc.Size = new System.Drawing.Size(223, 24);
            this.cbo_ncc.TabIndex = 5;
            this.cbo_ncc.SelectedIndexChanged += new System.EventHandler(this.cbo_ncc_SelectedIndexChanged);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 530);
            this.Controls.Add(this.cbo_ncc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_lhh);
            this.Name = "HangHoa";
            this.Text = "HangHoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HangHoa_FormClosing);
            this.Load += new System.EventHandler(this.HangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_hh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_lhh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView table_hh;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_ncc;
    }
}