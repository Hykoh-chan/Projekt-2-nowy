﻿namespace Projekt_2_nowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ImieText = new System.Windows.Forms.TextBox();
            this.NazText = new System.Windows.Forms.TextBox();
            this.stancombo = new System.Windows.Forms.ComboBox();
            this.pleccombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nowy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ImieText
            // 
            this.ImieText.Location = new System.Drawing.Point(119, 28);
            this.ImieText.Name = "ImieText";
            this.ImieText.Size = new System.Drawing.Size(195, 22);
            this.ImieText.TabIndex = 3;
            this.ImieText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NazText
            // 
            this.NazText.Location = new System.Drawing.Point(119, 76);
            this.NazText.Name = "NazText";
            this.NazText.Size = new System.Drawing.Size(195, 22);
            this.NazText.TabIndex = 4;
            // 
            // stancombo
            // 
            this.stancombo.FormattingEnabled = true;
            this.stancombo.Items.AddRange(new object[] {
            "Student",
            "Pracownik",
            "Obcy"});
            this.stancombo.Location = new System.Drawing.Point(119, 121);
            this.stancombo.Name = "stancombo";
            this.stancombo.Size = new System.Drawing.Size(195, 24);
            this.stancombo.TabIndex = 5;
            // 
            // pleccombo
            // 
            this.pleccombo.FormattingEnabled = true;
            this.pleccombo.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.pleccombo.Location = new System.Drawing.Point(119, 171);
            this.pleccombo.Name = "pleccombo";
            this.pleccombo.Size = new System.Drawing.Size(195, 24);
            this.pleccombo.TabIndex = 6;
            this.pleccombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imię: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stanowisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Płeć:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rok urodzenia:";
            // 
            // dataText
            // 
            this.dataText.Location = new System.Drawing.Point(119, 220);
            this.dataText.Name = "dataText";
            this.dataText.Size = new System.Drawing.Size(195, 22);
            this.dataText.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 598);
            this.Controls.Add(this.dataText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pleccombo);
            this.Controls.Add(this.stancombo);
            this.Controls.Add(this.NazText);
            this.Controls.Add(this.ImieText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ImieText;
        private System.Windows.Forms.TextBox NazText;
        private System.Windows.Forms.ComboBox stancombo;
        private System.Windows.Forms.ComboBox pleccombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dataText;
    }
}

