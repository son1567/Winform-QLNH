namespace QL_NHAHANG
{
    partial class DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DTN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DTT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_slsp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_lsp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbo_loaimonan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_thang = new System.Windows.Forms.ComboBox();
            this.btn_timthang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_nam = new System.Windows.Forms.ComboBox();
            this.btn_timnam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_nam1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_slsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lsp)).BeginInit();
            this.SuspendLayout();
            // 
            // DTN
            // 
            chartArea11.Name = "ChartArea1";
            this.DTN.ChartAreas.Add(chartArea11);
            legend9.Name = "Legend1";
            this.DTN.Legends.Add(legend9);
            this.DTN.Location = new System.Drawing.Point(37, 116);
            this.DTN.Name = "DTN";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.DTN.Series.Add(series9);
            this.DTN.Size = new System.Drawing.Size(807, 258);
            this.DTN.TabIndex = 0;
            this.DTN.Text = "Doanh thu theo ngày";
            // 
            // DTT
            // 
            chartArea12.Name = "ChartArea1";
            this.DTT.ChartAreas.Add(chartArea12);
            legend10.Name = "Legend1";
            this.DTT.Legends.Add(legend10);
            this.DTT.Location = new System.Drawing.Point(37, 425);
            this.DTT.Name = "DTT";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.DTT.Series.Add(series10);
            this.DTT.Size = new System.Drawing.Size(807, 258);
            this.DTT.TabIndex = 1;
            this.DTT.Text = "Doanh thu theo tháng";
            // 
            // chart_slsp
            // 
            chartArea13.Name = "ChartArea1";
            this.chart_slsp.ChartAreas.Add(chartArea13);
            legend11.Name = "Legend1";
            this.chart_slsp.Legends.Add(legend11);
            this.chart_slsp.Location = new System.Drawing.Point(880, 116);
            this.chart_slsp.Name = "chart_slsp";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart_slsp.Series.Add(series11);
            this.chart_slsp.Size = new System.Drawing.Size(653, 258);
            this.chart_slsp.TabIndex = 2;
            this.chart_slsp.Text = "Top sản phẩm có số lượng bán ra tốt nhất";
            // 
            // chart_lsp
            // 
            chartArea14.Name = "ChartArea1";
            chartArea15.Name = "ChartArea2";
            this.chart_lsp.ChartAreas.Add(chartArea14);
            this.chart_lsp.ChartAreas.Add(chartArea15);
            legend12.Name = "Legend1";
            this.chart_lsp.Legends.Add(legend12);
            this.chart_lsp.Location = new System.Drawing.Point(880, 396);
            this.chart_lsp.Name = "chart_lsp";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart_lsp.Series.Add(series12);
            this.chart_lsp.Size = new System.Drawing.Size(677, 287);
            this.chart_lsp.TabIndex = 3;
            this.chart_lsp.Text = "Doanh thu của các loại sản phẩm";
            // 
            // cbo_loaimonan
            // 
            this.cbo_loaimonan.FormattingEnabled = true;
            this.cbo_loaimonan.Location = new System.Drawing.Point(982, 71);
            this.cbo_loaimonan.Name = "cbo_loaimonan";
            this.cbo_loaimonan.Size = new System.Drawing.Size(301, 24);
            this.cbo_loaimonan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(877, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại món ăn";
            // 
            // btn_tk
            // 
            this.btn_tk.Location = new System.Drawing.Point(1345, 71);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(75, 23);
            this.btn_tk.TabIndex = 6;
            this.btn_tk.Text = "Tìm";
            this.btn_tk.UseVisualStyleBackColor = true;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tháng";
            // 
            // cbo_thang
            // 
            this.cbo_thang.FormattingEnabled = true;
            this.cbo_thang.Location = new System.Drawing.Point(89, 66);
            this.cbo_thang.Name = "cbo_thang";
            this.cbo_thang.Size = new System.Drawing.Size(127, 24);
            this.cbo_thang.TabIndex = 8;
            // 
            // btn_timthang
            // 
            this.btn_timthang.Location = new System.Drawing.Point(479, 67);
            this.btn_timthang.Name = "btn_timthang";
            this.btn_timthang.Size = new System.Drawing.Size(75, 23);
            this.btn_timthang.TabIndex = 9;
            this.btn_timthang.Text = "Tìm";
            this.btn_timthang.UseVisualStyleBackColor = true;
            this.btn_timthang.Click += new System.EventHandler(this.btn_timthang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Năm";
            // 
            // cbo_nam
            // 
            this.cbo_nam.FormattingEnabled = true;
            this.cbo_nam.Location = new System.Drawing.Point(139, 389);
            this.cbo_nam.Name = "cbo_nam";
            this.cbo_nam.Size = new System.Drawing.Size(301, 24);
            this.cbo_nam.TabIndex = 11;
            // 
            // btn_timnam
            // 
            this.btn_timnam.Location = new System.Drawing.Point(479, 389);
            this.btn_timnam.Name = "btn_timnam";
            this.btn_timnam.Size = new System.Drawing.Size(75, 23);
            this.btn_timnam.TabIndex = 12;
            this.btn_timnam.Text = "Tìm";
            this.btn_timnam.UseVisualStyleBackColor = true;
            this.btn_timnam.Click += new System.EventHandler(this.btn_timnam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Năm";
            // 
            // cbo_nam1
            // 
            this.cbo_nam1.FormattingEnabled = true;
            this.cbo_nam1.Location = new System.Drawing.Point(313, 64);
            this.cbo_nam1.Name = "cbo_nam1";
            this.cbo_nam1.Size = new System.Drawing.Size(127, 24);
            this.cbo_nam1.TabIndex = 14;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 877);
            this.Controls.Add(this.cbo_nam1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_timnam);
            this.Controls.Add(this.cbo_nam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_timthang);
            this.Controls.Add(this.cbo_thang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_loaimonan);
            this.Controls.Add(this.chart_lsp);
            this.Controls.Add(this.chart_slsp);
            this.Controls.Add(this.DTT);
            this.Controls.Add(this.DTN);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_slsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DTN;
        private System.Windows.Forms.DataVisualization.Charting.Chart DTT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_slsp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_lsp;
        private System.Windows.Forms.ComboBox cbo_loaimonan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_thang;
        private System.Windows.Forms.Button btn_timthang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_nam;
        private System.Windows.Forms.Button btn_timnam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_nam1;
    }
}