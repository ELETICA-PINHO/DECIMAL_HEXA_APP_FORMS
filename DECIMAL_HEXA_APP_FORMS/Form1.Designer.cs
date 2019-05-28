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
            this.textBox_Decimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Numero_hexa = new System.Windows.Forms.Label();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.linkLabel_Instagram = new System.Windows.Forms.LinkLabel();
            this.linkLabel_facebook = new System.Windows.Forms.LinkLabel();
            this.linkLabel_youtube = new System.Windows.Forms.LinkLabel();
            this.linkLabel_blogspot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSOR DE DECIMAL PARA HEXADECIMAL";
            // 
            // textBox_Decimal
            // 
            this.textBox_Decimal.Location = new System.Drawing.Point(160, 87);
            this.textBox_Decimal.Name = "textBox_Decimal";
            this.textBox_Decimal.Size = new System.Drawing.Size(132, 20);
            this.textBox_Decimal.TabIndex = 1;
            this.textBox_Decimal.TextChanged += new System.EventHandler(this.textBox_Decimal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digitar numero de 0 ha 300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero Hexa";
            // 
            // label_Numero_hexa
            // 
            this.label_Numero_hexa.AutoSize = true;
            this.label_Numero_hexa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Numero_hexa.Location = new System.Drawing.Point(256, 131);
            this.label_Numero_hexa.Name = "label_Numero_hexa";
            this.label_Numero_hexa.Size = new System.Drawing.Size(25, 22);
            this.label_Numero_hexa.TabIndex = 4;
            this.label_Numero_hexa.Text = "...";
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(382, 64);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 5;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(382, 118);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 6;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            // 
            // linkLabel_Instagram
            // 
            this.linkLabel_Instagram.AutoSize = true;
            this.linkLabel_Instagram.Location = new System.Drawing.Point(34, 343);
            this.linkLabel_Instagram.Name = "linkLabel_Instagram";
            this.linkLabel_Instagram.Size = new System.Drawing.Size(56, 13);
            this.linkLabel_Instagram.TabIndex = 7;
            this.linkLabel_Instagram.TabStop = true;
            this.linkLabel_Instagram.Text = "Instagram ";
            // 
            // linkLabel_facebook
            // 
            this.linkLabel_facebook.AutoSize = true;
            this.linkLabel_facebook.Location = new System.Drawing.Point(141, 343);
            this.linkLabel_facebook.Name = "linkLabel_facebook";
            this.linkLabel_facebook.Size = new System.Drawing.Size(55, 13);
            this.linkLabel_facebook.TabIndex = 8;
            this.linkLabel_facebook.TabStop = true;
            this.linkLabel_facebook.Text = "Facebook";
            // 
            // linkLabel_youtube
            // 
            this.linkLabel_youtube.AutoSize = true;
            this.linkLabel_youtube.Location = new System.Drawing.Point(251, 343);
            this.linkLabel_youtube.Name = "linkLabel_youtube";
            this.linkLabel_youtube.Size = new System.Drawing.Size(51, 13);
            this.linkLabel_youtube.TabIndex = 9;
            this.linkLabel_youtube.TabStop = true;
            this.linkLabel_youtube.Text = "YouTube";
            // 
            // linkLabel_blogspot
            // 
            this.linkLabel_blogspot.AutoSize = true;
            this.linkLabel_blogspot.Location = new System.Drawing.Point(369, 343);
            this.linkLabel_blogspot.Name = "linkLabel_blogspot";
            this.linkLabel_blogspot.Size = new System.Drawing.Size(48, 13);
            this.linkLabel_blogspot.TabIndex = 10;
            this.linkLabel_blogspot.TabStop = true;
            this.linkLabel_blogspot.Text = "Blogspot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.linkLabel_blogspot);
            this.Controls.Add(this.linkLabel_youtube);
            this.Controls.Add(this.linkLabel_facebook);
            this.Controls.Add(this.linkLabel_Instagram);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.label_Numero_hexa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Decimal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(525, 43);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Decimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Numero_hexa;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.LinkLabel linkLabel_Instagram;
        private System.Windows.Forms.LinkLabel linkLabel_facebook;
        private System.Windows.Forms.LinkLabel linkLabel_youtube;
        private System.Windows.Forms.LinkLabel linkLabel_blogspot;
    }
}

