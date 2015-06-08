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
        public string operacao;
        public string n1;
        public string n2;
        public string result;
        public int index = 0;
 
        public Form1()
        {
            binSum("1001", "1");
            InitializeComponent();    
        }

        public static double binToDec(string a, int index = 0)
        {
            if (index == 0) a = revStr(a);

            if (index > a.Length - 1)
                return 0;
            else
            {
                return binToDec(a, index + 1) + int.Parse(a.ElementAt(index).ToString()) * (Math.Pow(2, index));
            }
        }

        public static string decToBin(double b)
        {
            double rest = b % 2;
            double result = (b - rest) / 2;
                       
            if (b == 1)
            {
                return rest.ToString();
            }
            else
            {
                return decToBin(result) + rest.ToString();
            }
        }

        public static bool binMaior(string a, string b)
        {
            if (binToDec(a) > binToDec(b))
            {
                return true;
            }
            else if (binToDec(b) > binToDec(a))
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public static string[] igualarNum(string a, string b) {

           if(a.Length > b.Length)
            {
                int index = a.Length - b.Length;
                for(int i = 0;i < index;i++)
                {
                    b = "0" + b;
                }
            }
            else if(b.Length > a.Length)
            {
                int index = b.Length - a.Length;
                for(int i = 0;i< index;i++)
                {
                    a = "0" + a;
                }
            }
            return new string[2]{a,b};
        }
        
        public static string binSum(string a, string b)
        {
            char[] m1 = (igualarNum(a,b))[0].ToCharArray();
            char[] m2 = (igualarNum(a, b))[1].ToCharArray();
            string overflow = "";
            string result = "";
            
            for(int i = m1.Length - 1;i >= 0;i--)
            {
                if (string.IsNullOrWhiteSpace(overflow))
                {
                    if (m1[i].Equals('0') && m2[i].Equals('0')) result = "0" + result;
                    if (m1[i].Equals('0') && m2[i].Equals('1')) result = "1" + result;
                    if (m1[i].Equals('1') && m2[i].Equals('0')) result = "1" + result;
                    if (m1[i].Equals('1') && m2[i].Equals('1'))
                    {                       
                        result = "0" + result;
                        overflow = "1";
                    }
                }
               else if ((m1[i].Equals('0') && m2[i].Equals('1')) || m1[i].Equals('1') && m2[i].Equals('0'))
                {                    
                    result = "0" + result;
                    overflow = "1";
                }
                else if ((m1[i].Equals('0') && m2[i].Equals('0')))
                {                    
                    result = "1" + result;
                    overflow = "";
                }
                else if(m1[i].Equals('1') && m2[i].Equals('1'))
                {                   
                    result = "1" + result;
                    overflow = "1"; 
                }
            }
            return overflow + result;
          }

        public static string binSub(string a, string b)
        {
            string m1 = igualarNum(a, b)[0];
            string m2 = igualarNum(a, b)[1];

            m2 = binSum(binTroca(m2), "1");

            string result = binSum(m1, m2);
            result = result.Remove(0, 1);
            return result;
        }

        public static string binTroca(string a)
        {
            string result = a;
            result = result.Replace('1', 'b');
            result = result.Replace('0', '1');
            result = result.Replace('b', '0');

            return result;
        }

        static string revStr(string Word)
        {
            char[] bla = Word.ToCharArray();
            Array.Reverse(bla);
            string invertida = new String(bla);

            return invertida;
        }

        public static string binMul(string a, string b)
        {
            string result = b;
            for (int i = 0; i < binToDec(a) - 1; i++)
            {
                result = binSum(b, result);

            }
            return result;
        }

        public static string[] binDiv(string a, string b)
        {

            string index = "";

            for (int i = 1; i < int.MaxValue; i++)
            {
                index = binMul(b, decToBin(i));
                if (binMaior(index, a))
                {
                    return new string[2] { decToBin(i - 1), binSub(a, binSub(index, b)) };
                }
                else if (index == a)
                {
                    return new string[2] { decToBin(i), "0" };
                }
            }
            return new string[2];

        }

        private void Operacao_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Equals("NAN (NÃO É UM NÚMERO)"))
            {
                textbox.Text = "0";
            }
            Button xXx_operacao_xXx = sender as Button;
            operacao = xXx_operacao_xXx.Text;
            n1 = textbox.Text;
            segundo = true;
            eresultado = false;
            lastOperacao = "";
        }

        private void binario_Click(object sender, EventArgs e)
        {
            textbox.Text = decToBin(double.Parse(textbox.Text));
        }

        private void decimal_Click(object sender, EventArgs e)
        {
            textbox.Text = Convert.ToString(binToDec(textbox.Text, index = 0));
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
                            alertbox.Text = "";
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
                alertbox.Text = "";
            switch (operacao) { 
                    
                case "+":
                    eresultado = true;
                    if (lastOperacao == "") { n2 = textbox.Text; }
                    else { n1 = textbox.Text; }
                    lastOperacao = operacao;
                    textbox.Text = binSum(n1, n2);
                    Debug.Print(n1 + " | " + operacao + " | " + n2 + " | " + result);
                    eresultado = true;
                    break;
                case "-":
                   eresultado = true;
                   if (lastOperacao == "") { n2 = textbox.Text; }
                   else { n1 = textbox.Text; }
                   lastOperacao = operacao;
                   if (n1.Length != n2.Length && !(binMaior(n1, n2))) alertbox.Text = "Primeiro menor que segundo";
                   else { textbox.Text = binSub(n1, n2); }
                   Debug.Print(n1 + " | " + operacao + " | " + n2 + " | " + result);
                   eresultado = true;
                   break;
                case "*":
                   eresultado = true;
                   if (lastOperacao == "") { n2 = textbox.Text; }
                   else { n1 = textbox.Text; }
                   lastOperacao = operacao;
                   textbox.Text = binMul(n1, n2);
                   Debug.Print(n1 + " | " + operacao + " | " + n2 + " | " + result);
                   eresultado = true;
                   break;
                    case "/":
                   eresultado = true;
                   if (lastOperacao == "") { n2 = textbox.Text; }
                   else { n1 = textbox.Text; }
                   lastOperacao = operacao;
                   if (n1.Length != n2.Length && !(binMaior(n1, n2))) alertbox.Text = "Primeiro menor que segundo";
                   else
                   {
                       string[] r = binDiv(n1, n2);
                       textbox.Text = r[0] + " + Resto:" + r[1];
                   }                    
                   Debug.Print(n1 + " | " + operacao + " | " + n2 + " | " + result);
                   eresultado = true;
                   break;
         
            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
            lastOperacao = "";
            eresultado = true;
        }


            } 
        }
    

