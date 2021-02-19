using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form { 
    

       public Conta[] contas = new Conta[20];
       // public Acessada[] acessada = new Acessada[20];
       public int acessada;
       public Form2(Conta[] contas, int acessada)
        {
           InitializeComponent();

       this.contas = contas;
        this.acessada = acessada;


      }   
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          textBox7.Text = "" + contas[acessada].Saldo;
          textBox7.Text = "" + contas[acessada].Saldo;
   label8.Text = "banco " + contas[acessada].modelo;
        label11.Text = "bem vindo" + contas[acessada].Titular;
        }

        
        //sacar
        private void button4_Click(object sender, EventArgs e)
        {
            contas[acessada].saca(int.Parse(textBox8.Text));           
            textBox11.Text = "" + contas[acessada].Saldo;
        }
        //depositar
        private void button5_Click_1(object sender, EventArgs e)
        {
           contas[acessada].deposita(int.Parse(textBox11.Text));
            textBox11.Text = "" + contas[acessada].Saldo;
        }
        //transferencia
        private void button6_Click(object sender, EventArgs e)
        {
            contas[acessada].saca(int.Parse(textBox12.Text));
            
            textBox11.Text = "" + contas[acessada].Saldo;

            textBox8.Clear();

            int a = int.Parse(textBox10.Text);
            contas[a].deposita(int.Parse(textBox12.Text));
            textBox9.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //  Conta
            Conta login1 = new Conta();
            //   contas[acessada].saca(int.Parse(textBox8.Text));
            login1.Saldo = (double.Parse(textBox7.Text));

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

