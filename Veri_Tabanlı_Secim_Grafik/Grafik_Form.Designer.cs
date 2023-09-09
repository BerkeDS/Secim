namespace Veri_Tabanlı_Secim_Grafik
{
    partial class Grafik_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parti_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ilce_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A_progressBar = new System.Windows.Forms.ProgressBar();
            this.B_progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.C_progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.D_progressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.E_progressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.A_lbl = new System.Windows.Forms.Label();
            this.B_lbl = new System.Windows.Forms.Label();
            this.C_lbl = new System.Windows.Forms.Label();
            this.D_lbl = new System.Windows.Forms.Label();
            this.E_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parti_chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parti_chart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // parti_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.parti_chart.ChartAreas.Add(chartArea1);
            this.parti_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.parti_chart.Legends.Add(legend1);
            this.parti_chart.Location = new System.Drawing.Point(3, 21);
            this.parti_chart.Name = "parti_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.parti_chart.Series.Add(series1);
            this.parti_chart.Size = new System.Drawing.Size(778, 211);
            this.parti_chart.TabIndex = 0;
            this.parti_chart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.E_lbl);
            this.groupBox2.Controls.Add(this.D_lbl);
            this.groupBox2.Controls.Add(this.C_lbl);
            this.groupBox2.Controls.Add(this.B_lbl);
            this.groupBox2.Controls.Add(this.A_lbl);
            this.groupBox2.Controls.Add(this.E_progressBar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.D_progressBar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.C_progressBar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.B_progressBar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.A_progressBar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ilce_combobox);
            this.groupBox2.Location = new System.Drawing.Point(15, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // ilce_combobox
            // 
            this.ilce_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilce_combobox.FormattingEnabled = true;
            this.ilce_combobox.Location = new System.Drawing.Point(180, 39);
            this.ilce_combobox.Name = "ilce_combobox";
            this.ilce_combobox.Size = new System.Drawing.Size(379, 26);
            this.ilce_combobox.TabIndex = 0;
            this.ilce_combobox.SelectedIndexChanged += new System.EventHandler(this.ilce_combobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlçe Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "A Parti:";
            // 
            // A_progressBar
            // 
            this.A_progressBar.Location = new System.Drawing.Point(180, 90);
            this.A_progressBar.Maximum = 200;
            this.A_progressBar.Name = "A_progressBar";
            this.A_progressBar.Size = new System.Drawing.Size(429, 23);
            this.A_progressBar.TabIndex = 3;
            // 
            // B_progressBar
            // 
            this.B_progressBar.Location = new System.Drawing.Point(180, 119);
            this.B_progressBar.Maximum = 200;
            this.B_progressBar.Name = "B_progressBar";
            this.B_progressBar.Size = new System.Drawing.Size(429, 23);
            this.B_progressBar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "B Parti:";
            // 
            // C_progressBar
            // 
            this.C_progressBar.Location = new System.Drawing.Point(180, 148);
            this.C_progressBar.Maximum = 200;
            this.C_progressBar.Name = "C_progressBar";
            this.C_progressBar.Size = new System.Drawing.Size(429, 23);
            this.C_progressBar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "C Parti:";
            // 
            // D_progressBar
            // 
            this.D_progressBar.Location = new System.Drawing.Point(180, 177);
            this.D_progressBar.Maximum = 200;
            this.D_progressBar.Name = "D_progressBar";
            this.D_progressBar.Size = new System.Drawing.Size(429, 23);
            this.D_progressBar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "D Parti:";
            // 
            // E_progressBar
            // 
            this.E_progressBar.Location = new System.Drawing.Point(180, 206);
            this.E_progressBar.Maximum = 200;
            this.E_progressBar.Name = "E_progressBar";
            this.E_progressBar.Size = new System.Drawing.Size(429, 23);
            this.E_progressBar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "E Parti:";
            // 
            // A_lbl
            // 
            this.A_lbl.AutoSize = true;
            this.A_lbl.Location = new System.Drawing.Point(615, 90);
            this.A_lbl.Name = "A_lbl";
            this.A_lbl.Size = new System.Drawing.Size(26, 18);
            this.A_lbl.TabIndex = 12;
            this.A_lbl.Text = "00";
            // 
            // B_lbl
            // 
            this.B_lbl.AutoSize = true;
            this.B_lbl.Location = new System.Drawing.Point(615, 119);
            this.B_lbl.Name = "B_lbl";
            this.B_lbl.Size = new System.Drawing.Size(26, 18);
            this.B_lbl.TabIndex = 13;
            this.B_lbl.Text = "00";
            // 
            // C_lbl
            // 
            this.C_lbl.AutoSize = true;
            this.C_lbl.Location = new System.Drawing.Point(615, 148);
            this.C_lbl.Name = "C_lbl";
            this.C_lbl.Size = new System.Drawing.Size(26, 18);
            this.C_lbl.TabIndex = 14;
            this.C_lbl.Text = "00";
            // 
            // D_lbl
            // 
            this.D_lbl.AutoSize = true;
            this.D_lbl.Location = new System.Drawing.Point(615, 177);
            this.D_lbl.Name = "D_lbl";
            this.D_lbl.Size = new System.Drawing.Size(26, 18);
            this.D_lbl.TabIndex = 15;
            this.D_lbl.Text = "00";
            // 
            // E_lbl
            // 
            this.E_lbl.AutoSize = true;
            this.E_lbl.Location = new System.Drawing.Point(615, 206);
            this.E_lbl.Name = "E_lbl";
            this.E_lbl.Size = new System.Drawing.Size(26, 18);
            this.E_lbl.TabIndex = 16;
            this.E_lbl.Text = "00";
            // 
            // Grafik_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grafik_Form";
            this.Text = "Grafik Form";
            this.Load += new System.EventHandler(this.Grafik_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parti_chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart parti_chart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label E_lbl;
        private System.Windows.Forms.Label D_lbl;
        private System.Windows.Forms.Label C_lbl;
        private System.Windows.Forms.Label B_lbl;
        private System.Windows.Forms.Label A_lbl;
        private System.Windows.Forms.ProgressBar E_progressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar D_progressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar C_progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar B_progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar A_progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ilce_combobox;
    }
}