using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DECIMAL_HEXA_APP_FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        char[] vetor_Hexa = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        char convertQ = ' ';
        char convertR = ' ';
        string convert = " ";
        int convert_quociente = 0;
        int convert_resto = 0;
        int N_digitado = 0;
        int base_divisor = 16;
        char resto1 = ' ';
        int quociente1 = 0;


        




        private void textBox_Decimal_TextChanged(object sender, EventArgs e)
        {
            N_digitado = int.Parse(textBox_Decimal.Text);


        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (N_digitado <= 0 || N_digitado <= 300)  // condição numero
                {
                    convert_quociente = N_digitado / base_divisor;
                    convert_resto = N_digitado % base_divisor;

               


                    if (N_digitado <= 255) // ATE 256 DECIMAIS
                    {

                        if (convert_resto >= 0 || convert_resto <= 15)
                        {
                            convertR = vetor_Hexa[convert_resto];
                            convert = Convert.ToString(convertR);
                            label_Numero_hexa.Text = convert.ToString();

                        }

                        if(N_digitado >= 16)
                        {
                            convertQ = vetor_Hexa[convert_quociente];   //VETOR  para conversao CONVERSÃO numero  convert_quociente  resultado na busca do vertor
                            convertR = vetor_Hexa[convert_resto];       //VETOR CONVERSÃO     

                            convert = Convert.ToString(convertQ) + Convert.ToString(convertR);
                            label_Numero_hexa.Text = convert.ToString();

                        }


















                    }

                   
                    if (N_digitado >= 256)
                    {
                        quociente1 = convert_quociente;
                        resto1 = vetor_Hexa[convert_resto];  //menos sequinativo 3


                        if (convert_quociente >= 16)
                        {
                            convertQ = vetor_Hexa[quociente1 / base_divisor];  ////menos sequinativo 1
                            convertR = vetor_Hexa[quociente1 % base_divisor];  ////menos sequinativo 2

                        }

                        convert = Convert.ToString(convertQ) + Convert.ToString(convertR) + Convert.ToString(resto1);
                        //                                1                            2                             3
                        label_Numero_hexa.Text = convert.ToString();
                    }


                    


                } // if 0 300
                else
                {
                    MessageBox.Show("Valor não é permitido tente novamente, 0 a 300");

                }
               


            }
            catch (Exception)
            {
                MessageBox.Show("Erro");

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_Instagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("https://www.instagram.com/eletricapinho/");

        }

        private void linkLabel_facebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/El%C3%A9trica-Pinho-1309240619096347/");

        }

        private void linkLabel_youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCfwWEXZmV9y3PZhtJIJTAzA/videos?view_as=subscriber");
            Process.Start("https://www.youtube.com/channel/UCNEZXz8YNibbAG45imenfWA/videos?view_as=subscriber");

        }

        private void linkLabel_blogspot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://eletrica-pinho.blogspot.com/");
            Process.Start("https://eletricapinho.wordpress.com/");

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
