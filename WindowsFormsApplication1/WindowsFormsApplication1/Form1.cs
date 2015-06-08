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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

  
   
        public bool segundo = false;
        public string lastOperacao;
        public bool eresultado = false;
        public bool temvirgula = false;
        public string operacao;
        public string n1;
        public string n2;
        public string result;
     



        /*public string Converter(string a)
        {
            int CCount = -1;
            R = 0;
            
            foreach (char b in a)
            {
                CCount++;
            }

            foreach (char b in a)
            {
                if (double.Parse(b.ToString()) < 2)
                {
                    R += double.Parse(b.ToString()) * Math.Pow(2, CCount);
                }
                }

            return R.ToString();
        }*/


        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(binSum("101001","10"));
        }

        string[] igualarNum(string n1, string n2) {
            

            if(n1.Length > n2.Length)
            {
                int index = n1.Length - n2.Length;
                for(int i = 0;i < index;i++)
                {
                    n2 = "0" + n2;
                }
            }
            else if(n2.Length > n1.Length)
            {
                int index = n2.Length - n1.Length;
                for(int i = 0;i< index;i++)
                {
                    n1 = "0" + n1;
                }
            }
            return new string[2]{n1,n2}; 
        }
        
        public string binSum(string n1, string n2)
        {
            char[] m1 = igualarNum(n1,n2)[0].ToCharArray();
            char[] m2 = igualarNum(n1, n2)[1].ToCharArray();
            string overflow = "";
            string result = "";
            Console.WriteLine(igualarNum(n1, n2)[0] + "     " + igualarNum(n1, n2)[1]);
            for(int i = m1.Length - 1;i >= 0;i--)
            {
                if (string.IsNullOrWhiteSpace(overflow))
                {
                    if (m1[i].Equals('0') && m2[i].Equals('0')) result += "0";
                    if (m1[i].Equals('0') && m2[i].Equals('1')) result += "1";
                    if (m1[i].Equals('1') && m2[i].Equals('0')) result += "1";
                    if (m1[i].Equals('1') && m2[i].Equals('1'))
                    {
                        result += "0";
                        overflow = "1";
                    }
                }
                else if (m1[i].Equals('0') && m2[i].Equals('0')) 
                { 
                    result += "1";
                    overflow = "";
                }
                else if (m1[i].Equals('0') && m2[i].Equals('1') || m1[i].Equals('1') && m2[i].Equals('0'))
                {
                    result = "0";
                    overflow = "1";
                }
                else if(m1[i].Equals('1') && m2[i].Equals('1'))
                {
                    result = "1";
                    overflow = "1";
                }
            }
            result = overflow + result;
            char[] bla = result.ToCharArray();
            Array.Reverse(bla);
            return new string(bla);
        }

        private void Operacao_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Equals("NAN (NÃO É UM NÚMERO)"))
            {
                textbox.Text = "0";
              //  conta.Text = "0";
            }
            Button xXx_operacao_xXx = sender as Button;
            operacao = xXx_operacao_xXx.Text;
            Debug.Print(textbox.Text + " | " + operacao);
            n1 = textbox.Text;
            Debug.Print(n1 + " | " + operacao);
            temvirgula = false;
            segundo = true;
            eresultado = false;
            lastOperacao = "";
        
        
        
        
        }


        private void binario_Click(object sender, EventArgs e)
        {

        }

        private void decimal_Click(object sender, EventArgs e)
        {
           // textbox.Text = Converter(textbox.Text);
            
        }

       
        private void Number_Click(object sender, EventArgs e)
        {
            Button xXx_digito_xXx = sender as Button;
            lastOperacao = "";
            if (textbox.Text.Length <= 15)
            {
                if (segundo == true) { textbox.Text = ""; }
                segundo = false;
                if (textbox.Text != "0")
                   {
                        textbox.Text = textbox.Text + xXx_digito_xXx.Text;                   
                   }
                    else
                    {
                        if (eresultado == false)
                        {
                            textbox.Text = textbox.Text + xXx_digito_xXx.Text;
                        }
                        else
                        {
                            textbox.Text = xXx_digito_xXx.Text;
                            eresultado = false;
                        }
                    }
                }
                else
                {
                    textbox.Text = xXx_digito_xXx.Text;
                }
            }

        private void Igual_Click(object sender, EventArgs e)
        {
            switch (operacao) { 
                case "+":
                    eresultado = true;
                   /* if (lastOperacao == "") { n2 = Convert.ToDouble(textbox.Text); }
                    else { n1 = Convert.ToDouble(textbox.Text); }*/
                    //lastOperacao = operacao;
                    igualarNum(n1,n2);
                    textbox.Text = binSum(n1, n2);
                    Debug.Print(n1 + " | " + operacao + " | " + n2 + " | " + result);
                    //conta.Text = primeironm + " " + operacao + " " + segundonm + " = " + result;
                    break;
            }
        }


            } 
        }
    

