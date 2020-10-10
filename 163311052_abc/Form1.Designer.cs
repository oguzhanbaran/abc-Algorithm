namespace _163311052_abc
{
    partial class frmABC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABC));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.numericCS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.lblDegisimSayisi = new System.Windows.Forms.Label();
            this.lblFit = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGozcuFit = new System.Windows.Forms.Label();
            this.lblGozcuDegisim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblYIsci = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblXIsci = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericCS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericCS
            // 
            this.numericCS.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericCS.Location = new System.Drawing.Point(200, 31);
            this.numericCS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericCS.Name = "numericCS";
            this.numericCS.Size = new System.Drawing.Size(210, 26);
            this.numericCS.TabIndex = 0;
            this.numericCS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kolonideki arı sayısı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalistir);
            this.groupBox1.Controls.Add(this.numericCS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Parametreleri";
            // 
            // btnCalistir
            // 
            this.btnCalistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalistir.Location = new System.Drawing.Point(129, 63);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(137, 37);
            this.btnCalistir.TabIndex = 2;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.BtnCalistir_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(372, 47);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(352, 384);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // lblDegisimSayisi
            // 
            this.lblDegisimSayisi.AutoSize = true;
            this.lblDegisimSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblDegisimSayisi.Location = new System.Drawing.Point(369, 447);
            this.lblDegisimSayisi.Name = "lblDegisimSayisi";
            this.lblDegisimSayisi.Size = new System.Drawing.Size(159, 13);
            this.lblDegisimSayisi.TabIndex = 4;
            this.lblDegisimSayisi.Text = "Kolonideki toplam değişim sayısı:";
            // 
            // lblFit
            // 
            this.lblFit.AutoSize = true;
            this.lblFit.ForeColor = System.Drawing.Color.Red;
            this.lblFit.Location = new System.Drawing.Point(369, 478);
            this.lblFit.Name = "lblFit";
            this.lblFit.Size = new System.Drawing.Size(120, 13);
            this.lblFit.TabIndex = 5;
            this.lblFit.Text = "En uygun fitness değeri:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 384);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 68);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblY);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(228, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 38);
            this.panel3.TabIndex = 2;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(3, 9);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 20);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblX);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 38);
            this.panel2.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(6, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 20);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gözcü Arı Bilgileri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "İşçi Arı Bilgileri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gözcü arı için en iyi konum:";
            // 
            // lblGozcuFit
            // 
            this.lblGozcuFit.AutoSize = true;
            this.lblGozcuFit.ForeColor = System.Drawing.Color.Red;
            this.lblGozcuFit.Location = new System.Drawing.Point(7, 478);
            this.lblGozcuFit.Name = "lblGozcuFit";
            this.lblGozcuFit.Size = new System.Drawing.Size(120, 13);
            this.lblGozcuFit.TabIndex = 12;
            this.lblGozcuFit.Text = "En uygun fitness değeri:";
            // 
            // lblGozcuDegisim
            // 
            this.lblGozcuDegisim.AutoSize = true;
            this.lblGozcuDegisim.ForeColor = System.Drawing.Color.Red;
            this.lblGozcuDegisim.Location = new System.Drawing.Point(7, 447);
            this.lblGozcuDegisim.Name = "lblGozcuDegisim";
            this.lblGozcuDegisim.Size = new System.Drawing.Size(159, 13);
            this.lblGozcuDegisim.TabIndex = 11;
            this.lblGozcuDegisim.Text = "Kolonideki toplam değişim sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "İşçi arı için en iyi konum:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(12, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 68);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.lblYIsci);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(228, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 38);
            this.panel5.TabIndex = 2;
            // 
            // lblYIsci
            // 
            this.lblYIsci.AutoSize = true;
            this.lblYIsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYIsci.Location = new System.Drawing.Point(3, 9);
            this.lblYIsci.Name = "lblYIsci";
            this.lblYIsci.Size = new System.Drawing.Size(21, 20);
            this.lblYIsci.TabIndex = 8;
            this.lblYIsci.Text = "Y";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblXIsci);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(12, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 38);
            this.panel6.TabIndex = 1;
            // 
            // lblXIsci
            // 
            this.lblXIsci.AutoSize = true;
            this.lblXIsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXIsci.Location = new System.Drawing.Point(6, 9);
            this.lblXIsci.Name = "lblXIsci";
            this.lblXIsci.Size = new System.Drawing.Size(21, 20);
            this.lblXIsci.TabIndex = 7;
            this.lblXIsci.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tabControl1);
            this.panel7.Location = new System.Drawing.Point(441, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(749, 549);
            this.panel7.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.Controls.Add(this.lblDegisimSayisi);
            this.tabPage1.Controls.Add(this.lblFit);
            this.tabPage1.Controls.Add(this.lblGozcuFit);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.lblGozcuDegisim);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fonksiyon sonuçları";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yakınsama Grafiği";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 8);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(722, 503);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            // 
            // frmABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 581);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmABC";
            this.Text = "ABC";
            this.Load += new System.EventHandler(this.FrmABC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericCS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label lblDegisimSayisi;
        private System.Windows.Forms.Label lblFit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGozcuFit;
        private System.Windows.Forms.Label lblGozcuDegisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblYIsci;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblXIsci;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

