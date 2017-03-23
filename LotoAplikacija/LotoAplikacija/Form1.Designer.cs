namespace LotoAplikacija
{
    partial class FrmLoto
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
            this.groupBoxUplaceni = new System.Windows.Forms.GroupBox();
            this.textBoxUplaceniBrojX = new System.Windows.Forms.TextBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.groupBoxDobitni = new System.Windows.Forms.GroupBox();
            this.txtDobitniBrojX = new System.Windows.Forms.TextBox();
            this.buttonOdigraj = new System.Windows.Forms.Button();
            this.Natpis = new System.Windows.Forms.Label();
            this.lblBrojPogodaka = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.groupBoxUplaceni.SuspendLayout();
            this.groupBoxDobitni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUplaceni
            // 
            this.groupBoxUplaceni.Controls.Add(this.textBox6);
            this.groupBoxUplaceni.Controls.Add(this.textBox5);
            this.groupBoxUplaceni.Controls.Add(this.textBox4);
            this.groupBoxUplaceni.Controls.Add(this.textBox3);
            this.groupBoxUplaceni.Controls.Add(this.textBox2);
            this.groupBoxUplaceni.Controls.Add(this.textBox1);
            this.groupBoxUplaceni.Controls.Add(this.btnUplati);
            this.groupBoxUplaceni.Controls.Add(this.textBoxUplaceniBrojX);
            this.groupBoxUplaceni.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUplaceni.Name = "groupBoxUplaceni";
            this.groupBoxUplaceni.Size = new System.Drawing.Size(352, 100);
            this.groupBoxUplaceni.TabIndex = 0;
            this.groupBoxUplaceni.TabStop = false;
            this.groupBoxUplaceni.Text = "UplaćenaKombinacija";
            this.groupBoxUplaceni.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxUplaceniBrojX
            // 
            this.textBoxUplaceniBrojX.Location = new System.Drawing.Point(23, 29);
            this.textBoxUplaceniBrojX.Name = "textBoxUplaceniBrojX";
            this.textBoxUplaceniBrojX.Size = new System.Drawing.Size(40, 20);
            this.textBoxUplaceniBrojX.TabIndex = 0;
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(271, 71);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 23);
            this.btnUplati.TabIndex = 1;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            // 
            // groupBoxDobitni
            // 
            this.groupBoxDobitni.Controls.Add(this.textBox12);
            this.groupBoxDobitni.Controls.Add(this.textBox11);
            this.groupBoxDobitni.Controls.Add(this.textBox10);
            this.groupBoxDobitni.Controls.Add(this.textBox9);
            this.groupBoxDobitni.Controls.Add(this.textBox8);
            this.groupBoxDobitni.Controls.Add(this.textBox7);
            this.groupBoxDobitni.Controls.Add(this.buttonOdigraj);
            this.groupBoxDobitni.Controls.Add(this.txtDobitniBrojX);
            this.groupBoxDobitni.Location = new System.Drawing.Point(6, 129);
            this.groupBoxDobitni.Name = "groupBoxDobitni";
            this.groupBoxDobitni.Size = new System.Drawing.Size(349, 100);
            this.groupBoxDobitni.TabIndex = 2;
            this.groupBoxDobitni.TabStop = false;
            this.groupBoxDobitni.Text = "Dobitna kombinacija";
            // 
            // txtDobitniBrojX
            // 
            this.txtDobitniBrojX.Location = new System.Drawing.Point(20, 19);
            this.txtDobitniBrojX.Name = "txtDobitniBrojX";
            this.txtDobitniBrojX.ReadOnly = true;
            this.txtDobitniBrojX.Size = new System.Drawing.Size(40, 20);
            this.txtDobitniBrojX.TabIndex = 1;
            this.txtDobitniBrojX.TextChanged += new System.EventHandler(this.txtDobitniBrojX_TextChanged);
            // 
            // buttonOdigraj
            // 
            this.buttonOdigraj.Location = new System.Drawing.Point(268, 50);
            this.buttonOdigraj.Name = "buttonOdigraj";
            this.buttonOdigraj.Size = new System.Drawing.Size(75, 23);
            this.buttonOdigraj.TabIndex = 2;
            this.buttonOdigraj.Text = "Odigraj";
            this.buttonOdigraj.UseVisualStyleBackColor = true;
            this.buttonOdigraj.Click += new System.EventHandler(this.buttonOdigraj_Click);
            // 
            // Natpis
            // 
            this.Natpis.AutoSize = true;
            this.Natpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Natpis.Location = new System.Drawing.Point(12, 239);
            this.Natpis.Name = "Natpis";
            this.Natpis.Size = new System.Drawing.Size(90, 13);
            this.Natpis.TabIndex = 3;
            this.Natpis.Text = "BrojPogodaka:";
            this.Natpis.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBrojPogodaka
            // 
            this.lblBrojPogodaka.AutoSize = true;
            this.lblBrojPogodaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojPogodaka.Location = new System.Drawing.Point(115, 239);
            this.lblBrojPogodaka.Name = "lblBrojPogodaka";
            this.lblBrojPogodaka.Size = new System.Drawing.Size(26, 13);
            this.lblBrojPogodaka.TabIndex = 4;
            this.lblBrojPogodaka.Text = "\"0\"";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(253, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(299, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(66, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(40, 20);
            this.textBox7.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(112, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(40, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(158, 19);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(40, 20);
            this.textBox9.TabIndex = 5;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(204, 19);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(40, 20);
            this.textBox10.TabIndex = 6;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(250, 19);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(40, 20);
            this.textBox11.TabIndex = 7;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(296, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(40, 20);
            this.textBox12.TabIndex = 8;
            // 
            // FrmLoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.lblBrojPogodaka);
            this.Controls.Add(this.Natpis);
            this.Controls.Add(this.groupBoxDobitni);
            this.Controls.Add(this.groupBoxUplaceni);
            this.Name = "FrmLoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loto 7/39";
            this.groupBoxUplaceni.ResumeLayout(false);
            this.groupBoxUplaceni.PerformLayout();
            this.groupBoxDobitni.ResumeLayout(false);
            this.groupBoxDobitni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUplaceni;
        private System.Windows.Forms.TextBox textBoxUplaceniBrojX;
        private System.Windows.Forms.GroupBox groupBoxDobitni;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.Button buttonOdigraj;
        private System.Windows.Forms.TextBox txtDobitniBrojX;
        private System.Windows.Forms.Label Natpis;
        private System.Windows.Forms.Label lblBrojPogodaka;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
    }
}

