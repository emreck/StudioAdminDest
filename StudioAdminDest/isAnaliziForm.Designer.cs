namespace StudioAdminDest
{
    partial class isAnaliziForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.isAnalizYenile = new System.Windows.Forms.Button();
            this.aylik = new System.Windows.Forms.TextBox();
            this.aylikKazanc = new System.Windows.Forms.Label();
            this.aylikIsletmeGiderLbl = new System.Windows.Forms.Label();
            this.aylikIsletmeGider = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(58, 35);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "veriler";
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // isAnalizYenile
            // 
            this.isAnalizYenile.Location = new System.Drawing.Point(410, 237);
            this.isAnalizYenile.Name = "isAnalizYenile";
            this.isAnalizYenile.Size = new System.Drawing.Size(105, 78);
            this.isAnalizYenile.TabIndex = 1;
            this.isAnalizYenile.Text = "YENİLE";
            this.isAnalizYenile.UseVisualStyleBackColor = true;
            this.isAnalizYenile.Click += new System.EventHandler(this.isAnalizYenile_Click);
            // 
            // aylik
            // 
            this.aylik.Enabled = false;
            this.aylik.Location = new System.Drawing.Point(419, 67);
            this.aylik.Name = "aylik";
            this.aylik.Size = new System.Drawing.Size(96, 20);
            this.aylik.TabIndex = 2;
            // 
            // aylikKazanc
            // 
            this.aylikKazanc.AutoSize = true;
            this.aylikKazanc.Location = new System.Drawing.Point(416, 51);
            this.aylikKazanc.Name = "aylikKazanc";
            this.aylikKazanc.Size = new System.Drawing.Size(99, 13);
            this.aylikKazanc.TabIndex = 3;
            this.aylikKazanc.Text = "AYLIK İŞ KAZANCI";
            // 
            // aylikIsletmeGiderLbl
            // 
            this.aylikIsletmeGiderLbl.AutoSize = true;
            this.aylikIsletmeGiderLbl.Location = new System.Drawing.Point(407, 128);
            this.aylikIsletmeGiderLbl.Name = "aylikIsletmeGiderLbl";
            this.aylikIsletmeGiderLbl.Size = new System.Drawing.Size(126, 13);
            this.aylikIsletmeGiderLbl.TabIndex = 4;
            this.aylikIsletmeGiderLbl.Text = "AYLIK İŞLETME GİDERİ";
            // 
            // aylikIsletmeGider
            // 
            this.aylikIsletmeGider.Enabled = false;
            this.aylikIsletmeGider.Location = new System.Drawing.Point(419, 163);
            this.aylikIsletmeGider.Name = "aylikIsletmeGider";
            this.aylikIsletmeGider.Size = new System.Drawing.Size(96, 20);
            this.aylikIsletmeGider.TabIndex = 5;
            // 
            // isAnaliziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 376);
            this.Controls.Add(this.aylikIsletmeGider);
            this.Controls.Add(this.aylikIsletmeGiderLbl);
            this.Controls.Add(this.aylikKazanc);
            this.Controls.Add(this.aylik);
            this.Controls.Add(this.isAnalizYenile);
            this.Controls.Add(this.chart1);
            this.Name = "isAnaliziForm";
            this.Text = "İŞ ANALİZİ&GİDER-GELİR";
            this.Load += new System.EventHandler(this.isAnaliziForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button isAnalizYenile;
        private System.Windows.Forms.TextBox aylik;
        private System.Windows.Forms.Label aylikKazanc;
        private System.Windows.Forms.Label aylikIsletmeGiderLbl;
        private System.Windows.Forms.TextBox aylikIsletmeGider;
    }
}