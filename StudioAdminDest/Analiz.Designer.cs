namespace StudioAdminDest
{
    partial class Analiz
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.analizYenile = new System.Windows.Forms.Button();
            this.kzncLabel = new System.Windows.Forms.Label();
            this.aylikIsletmeKazanc = new System.Windows.Forms.TextBox();
            this.aylikIsletmeGider = new System.Windows.Forms.TextBox();
            this.gdrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(66, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "veriler";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // analizYenile
            // 
            this.analizYenile.Location = new System.Drawing.Point(420, 246);
            this.analizYenile.Name = "analizYenile";
            this.analizYenile.Size = new System.Drawing.Size(75, 57);
            this.analizYenile.TabIndex = 1;
            this.analizYenile.Text = "YENİLE";
            this.analizYenile.UseVisualStyleBackColor = true;
            this.analizYenile.Click += new System.EventHandler(this.analizYenile_Click);
            // 
            // kzncLabel
            // 
            this.kzncLabel.AutoSize = true;
            this.kzncLabel.Location = new System.Drawing.Point(408, 75);
            this.kzncLabel.Name = "kzncLabel";
            this.kzncLabel.Size = new System.Drawing.Size(83, 13);
            this.kzncLabel.TabIndex = 2;
            this.kzncLabel.Text = "AYLIK KAZANÇ";
            // 
            // aylikIsletmeKazanc
            // 
            this.aylikIsletmeKazanc.Enabled = false;
            this.aylikIsletmeKazanc.Location = new System.Drawing.Point(408, 91);
            this.aylikIsletmeKazanc.Name = "aylikIsletmeKazanc";
            this.aylikIsletmeKazanc.Size = new System.Drawing.Size(100, 20);
            this.aylikIsletmeKazanc.TabIndex = 3;
            // 
            // aylikIsletmeGider
            // 
            this.aylikIsletmeGider.Enabled = false;
            this.aylikIsletmeGider.Location = new System.Drawing.Point(408, 189);
            this.aylikIsletmeGider.Name = "aylikIsletmeGider";
            this.aylikIsletmeGider.Size = new System.Drawing.Size(100, 20);
            this.aylikIsletmeGider.TabIndex = 4;
            // 
            // gdrLabel
            // 
            this.gdrLabel.AutoSize = true;
            this.gdrLabel.Location = new System.Drawing.Point(417, 173);
            this.gdrLabel.Name = "gdrLabel";
            this.gdrLabel.Size = new System.Drawing.Size(74, 13);
            this.gdrLabel.TabIndex = 5;
            this.gdrLabel.Text = "AYLIK GİDER";
            // 
            // Analiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 336);
            this.Controls.Add(this.gdrLabel);
            this.Controls.Add(this.aylikIsletmeGider);
            this.Controls.Add(this.aylikIsletmeKazanc);
            this.Controls.Add(this.kzncLabel);
            this.Controls.Add(this.analizYenile);
            this.Controls.Add(this.chart1);
            this.Name = "Analiz";
            this.Text = "Analiz";
            this.Load += new System.EventHandler(this.Analiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button analizYenile;
        private System.Windows.Forms.Label kzncLabel;
        private System.Windows.Forms.TextBox aylikIsletmeKazanc;
        private System.Windows.Forms.TextBox aylikIsletmeGider;
        private System.Windows.Forms.Label gdrLabel;
    }
}