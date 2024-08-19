namespace QL_NHAHANG
{
    partial class TrangChu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dnnv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dnql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập cho nhân viên";
            // 
            // btn_dnnv
            // 
            this.btn_dnnv.Location = new System.Drawing.Point(370, 129);
            this.btn_dnnv.Name = "btn_dnnv";
            this.btn_dnnv.Size = new System.Drawing.Size(173, 34);
            this.btn_dnnv.TabIndex = 1;
            this.btn_dnnv.Text = "Đăng nhập Nhân Viên";
            this.btn_dnnv.UseVisualStyleBackColor = true;
            this.btn_dnnv.Click += new System.EventHandler(this.btn_dnnv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đăng nhập cho quản lý";
            // 
            // btn_dnql
            // 
            this.btn_dnql.Location = new System.Drawing.Point(370, 219);
            this.btn_dnql.Name = "btn_dnql";
            this.btn_dnql.Size = new System.Drawing.Size(173, 34);
            this.btn_dnql.TabIndex = 3;
            this.btn_dnql.Text = "Đăng nhập quản lý";
            this.btn_dnql.UseVisualStyleBackColor = true;
            this.btn_dnql.Click += new System.EventHandler(this.btn_dnql_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 429);
            this.Controls.Add(this.btn_dnql);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dnnv);
            this.Controls.Add(this.label1);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dnnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_dnql;
    }
}