namespace arraylist_n96
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir Adı :";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(47, 63);
            this.txtSehir.Multiline = true;
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(181, 25);
            this.txtSehir.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.Location = new System.Drawing.Point(47, 103);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 35);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(47, 155);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(181, 277);
            this.lbListe.TabIndex = 3;
            // 
            // btnListe
            // 
            this.btnListe.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnListe.Location = new System.Drawing.Point(147, 103);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(81, 35);
            this.btnListe.TabIndex = 4;
            this.btnListe.Text = "LİSTELE";
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 467);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnListe;
    }
}

