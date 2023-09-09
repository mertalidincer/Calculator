namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTxtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnArtiVeEksi = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnNokta = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnToplama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTxtDisplay
            // 
            this.rTxtDisplay.BackColor = System.Drawing.Color.White;
            this.rTxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtDisplay.Location = new System.Drawing.Point(12, 33);
            this.rTxtDisplay.Name = "rTxtDisplay";
            this.rTxtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rTxtDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTxtDisplay.Size = new System.Drawing.Size(469, 62);
            this.rTxtDisplay.TabIndex = 4;
            this.rTxtDisplay.Text = "0";
            this.rTxtDisplay.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btnArtiVeEksi
            // 
            this.btnArtiVeEksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtiVeEksi.Location = new System.Drawing.Point(12, 401);
            this.btnArtiVeEksi.Name = "btnArtiVeEksi";
            this.btnArtiVeEksi.Size = new System.Drawing.Size(89, 94);
            this.btnArtiVeEksi.TabIndex = 5;
            this.btnArtiVeEksi.Text = "+/-";
            this.btnArtiVeEksi.UseVisualStyleBackColor = true;
            this.btnArtiVeEksi.Click += new System.EventHandler(this.btnArtiVeEksi_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(107, 401);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(89, 94);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btnNokta
            // 
            this.btnNokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNokta.Location = new System.Drawing.Point(202, 401);
            this.btnNokta.Name = "btnNokta";
            this.btnNokta.Size = new System.Drawing.Size(89, 94);
            this.btnNokta.TabIndex = 5;
            this.btnNokta.Text = ",";
            this.btnNokta.UseVisualStyleBackColor = true;
            this.btnNokta.Click += new System.EventHandler(this.btnNokta_Click);
            // 
            // btnEsittir
            // 
            this.btnEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsittir.Location = new System.Drawing.Point(392, 301);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(89, 194);
            this.btnEsittir.TabIndex = 5;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = true;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click_2);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(12, 301);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 94);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(107, 301);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(89, 94);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(202, 301);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 94);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(12, 201);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(89, 94);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(107, 201);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(89, 94);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(202, 201);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 94);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackSpace.Location = new System.Drawing.Point(392, 201);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(89, 94);
            this.btnBackSpace.TabIndex = 5;
            this.btnBackSpace.Text = "<<";
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(12, 101);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(89, 94);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(107, 101);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(89, 94);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(202, 101);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 94);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnsRakamlar);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnC.Location = new System.Drawing.Point(392, 101);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(89, 94);
            this.BtnC.TabIndex = 5;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolme.Location = new System.Drawing.Point(297, 401);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(89, 94);
            this.btnBolme.TabIndex = 5;
            this.btnBolme.Text = "/";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarpma.Location = new System.Drawing.Point(297, 301);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(89, 94);
            this.btnCarpma.TabIndex = 5;
            this.btnCarpma.Text = "*";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikarma.Location = new System.Drawing.Point(297, 201);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(89, 94);
            this.btnCikarma.TabIndex = 5;
            this.btnCikarma.Text = "-";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnToplama
            // 
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplama.Location = new System.Drawing.Point(297, 101);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(89, 94);
            this.btnToplama.TabIndex = 5;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 503);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnNokta);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnArtiVeEksi);
            this.Controls.Add(this.rTxtDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makibesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnsRakamlar);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rTxtDisplay;
        private System.Windows.Forms.Button btnArtiVeEksi;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnNokta;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnToplama;
    }
}

