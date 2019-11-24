namespace KonyvespolcApp
{
    partial class Form1
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
            this.lista = new System.Windows.Forms.ListBox();
            this.label_ujkonyv = new System.Windows.Forms.Label();
            this.konyv_text = new System.Windows.Forms.TextBox();
            this.hozzaad_button = new System.Windows.Forms.Button();
            this.mentes_button = new System.Windows.Forms.Button();
            this.betoltes_button = new System.Windows.Forms.Button();
            this.label_aktualmax = new System.Windows.Forms.Label();
            this.label_per = new System.Windows.Forms.Label();
            this.aktualis_num = new System.Windows.Forms.NumericUpDown();
            this.max_num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.aktualis_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_num)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(120, 95);
            this.lista.TabIndex = 0;
            // 
            // label_ujkonyv
            // 
            this.label_ujkonyv.AutoSize = true;
            this.label_ujkonyv.Location = new System.Drawing.Point(12, 110);
            this.label_ujkonyv.Name = "label_ujkonyv";
            this.label_ujkonyv.Size = new System.Drawing.Size(52, 13);
            this.label_ujkonyv.TabIndex = 1;
            this.label_ujkonyv.Text = "Új könyv:";
            // 
            // konyv_text
            // 
            this.konyv_text.Location = new System.Drawing.Point(12, 126);
            this.konyv_text.Name = "konyv_text";
            this.konyv_text.Size = new System.Drawing.Size(100, 20);
            this.konyv_text.TabIndex = 2;
            // 
            // hozzaad_button
            // 
            this.hozzaad_button.Location = new System.Drawing.Point(12, 152);
            this.hozzaad_button.Name = "hozzaad_button";
            this.hozzaad_button.Size = new System.Drawing.Size(75, 23);
            this.hozzaad_button.TabIndex = 5;
            this.hozzaad_button.Text = "Hozzáad";
            this.hozzaad_button.UseVisualStyleBackColor = true;
            this.hozzaad_button.Click += new System.EventHandler(this.hozzaad_button_Click);
            // 
            // mentes_button
            // 
            this.mentes_button.Location = new System.Drawing.Point(118, 152);
            this.mentes_button.Name = "mentes_button";
            this.mentes_button.Size = new System.Drawing.Size(75, 23);
            this.mentes_button.TabIndex = 6;
            this.mentes_button.Text = "Mentés";
            this.mentes_button.UseVisualStyleBackColor = true;
            this.mentes_button.Click += new System.EventHandler(this.mentes_button_Click);
            // 
            // betoltes_button
            // 
            this.betoltes_button.Location = new System.Drawing.Point(199, 152);
            this.betoltes_button.Name = "betoltes_button";
            this.betoltes_button.Size = new System.Drawing.Size(75, 23);
            this.betoltes_button.TabIndex = 7;
            this.betoltes_button.Text = "Betöltés";
            this.betoltes_button.UseVisualStyleBackColor = true;
            this.betoltes_button.Click += new System.EventHandler(this.betoltes_button_Click);
            // 
            // label_aktualmax
            // 
            this.label_aktualmax.AutoSize = true;
            this.label_aktualmax.Location = new System.Drawing.Point(138, 12);
            this.label_aktualmax.Name = "label_aktualmax";
            this.label_aktualmax.Size = new System.Drawing.Size(78, 13);
            this.label_aktualmax.TabIndex = 8;
            this.label_aktualmax.Text = "Aktuális / Max.";
            // 
            // label_per
            // 
            this.label_per.AutoSize = true;
            this.label_per.Location = new System.Drawing.Point(204, 33);
            this.label_per.Name = "label_per";
            this.label_per.Size = new System.Drawing.Size(12, 13);
            this.label_per.TabIndex = 9;
            this.label_per.Text = "/";
            this.label_per.Click += new System.EventHandler(this.label_per_Click);
            // 
            // aktualis_num
            // 
            this.aktualis_num.Location = new System.Drawing.Point(141, 31);
            this.aktualis_num.Name = "aktualis_num";
            this.aktualis_num.Size = new System.Drawing.Size(52, 20);
            this.aktualis_num.TabIndex = 10;
            // 
            // max_num
            // 
            this.max_num.Location = new System.Drawing.Point(222, 31);
            this.max_num.Name = "max_num";
            this.max_num.Size = new System.Drawing.Size(52, 20);
            this.max_num.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 184);
            this.Controls.Add(this.max_num);
            this.Controls.Add(this.aktualis_num);
            this.Controls.Add(this.label_per);
            this.Controls.Add(this.label_aktualmax);
            this.Controls.Add(this.betoltes_button);
            this.Controls.Add(this.mentes_button);
            this.Controls.Add(this.hozzaad_button);
            this.Controls.Add(this.konyv_text);
            this.Controls.Add(this.label_ujkonyv);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.aktualis_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label_ujkonyv;
        private System.Windows.Forms.TextBox konyv_text;
        private System.Windows.Forms.Button hozzaad_button;
        private System.Windows.Forms.Button mentes_button;
        private System.Windows.Forms.Button betoltes_button;
        private System.Windows.Forms.Label label_aktualmax;
        private System.Windows.Forms.Label label_per;
        private System.Windows.Forms.NumericUpDown aktualis_num;
        private System.Windows.Forms.NumericUpDown max_num;
    }
}

