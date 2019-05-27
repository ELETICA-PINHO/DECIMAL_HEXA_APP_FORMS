namespace DECIMAL_HEXA_APP_FORMS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Decimal = new System.Windows.Forms.TextBox();
            this.lbl_Numero_Convertido_hexa = new System.Windows.Forms.Label();
            this.lbl_convert = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSOR DE DECIMAL PARA HEXADECIMAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO DECIMAL 0 A 300";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Decimal
            // 
            this.txt_Decimal.Location = new System.Drawing.Point(165, 101);
            this.txt_Decimal.Multiline = true;
            this.txt_Decimal.Name = "txt_Decimal";
            this.txt_Decimal.Size = new System.Drawing.Size(152, 20);
            this.txt_Decimal.TabIndex = 2;
            this.txt_Decimal.TextChanged += new System.EventHandler(this.txt_Decimal_TextChanged);
            // 
            // lbl_Numero_Convertido_hexa
            // 
            this.lbl_Numero_Convertido_hexa.AutoSize = true;
            this.lbl_Numero_Convertido_hexa.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero_Convertido_hexa.ForeColor = System.Drawing.Color.Red;
            this.lbl_Numero_Convertido_hexa.Location = new System.Drawing.Point(190, 159);
            this.lbl_Numero_Convertido_hexa.Name = "lbl_Numero_Convertido_hexa";
            this.lbl_Numero_Convertido_hexa.Size = new System.Drawing.Size(0, 32);
            this.lbl_Numero_Convertido_hexa.TabIndex = 3;
            // 
            // lbl_convert
            // 
            this.lbl_convert.AutoSize = true;
            this.lbl_convert.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_convert.ForeColor = System.Drawing.Color.Red;
            this.lbl_convert.Location = new System.Drawing.Point(215, 165);
            this.lbl_convert.Name = "lbl_convert";
            this.lbl_convert.Size = new System.Drawing.Size(28, 24);
            this.lbl_convert.TabIndex = 4;
            this.lbl_convert.Text = "...";
            this.lbl_convert.Click += new System.EventHandler(this.lbl_convert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero Hexa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_convert);
            this.Controls.Add(this.lbl_Numero_Convertido_hexa);
            this.Controls.Add(this.txt_Decimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 489);
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Decimal;
        private System.Windows.Forms.Label lbl_Numero_Convertido_hexa;
        private System.Windows.Forms.Label lbl_convert;
        private System.Windows.Forms.Label label3;
    }
}

