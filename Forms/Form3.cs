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
    public partial class Form3 : Form
    {
        public Conta[] contas = new Conta[20];
        public Banco[] banco = new Banco[20];
        int ultimo;
        int acessada;
        public Form3(Conta[] contas, int ultimo)
        {
            this.contas = contas;
            this.ultimo = ultimo;
            InitializeComponent();
            //comboBox1.Items.Add("Conta Corrente");
            //comboBox1.Items.Add("Conta Poupança");
            //comboBox2.Items.Add("Ilau");
            //comboBox2.Items.Add("Ilau premium");
            comboBox2.Items.Add("Conta Corrente");
            comboBox2.Items.Add("Conta Poupança");
            comboBox1.Items.Add("Ilau");
            comboBox1.Items.Add("Ilau premium");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banco[ultimo] = new Banco();
            banco[ultimo].modelo = comboBox1.SelectedItem.ToString();

            switch (comboBox2.SelectedItem.ToString())
            {
                case  "Conta Corrente":
                    contas[ultimo] = new ContaCorrente();
                    break;
                case "Conta Poupança":
                    contas[ultimo] = new ContaPoupanca();
                    break;
            }
            contas[ultimo].Titular = textBox1.Text;
            contas[ultimo].Saldo = 0;
            contas[ultimo].Numero = ultimo;
            
            //contas[ultimo].banco = banco[ultimo];
            ultimo++;

            //MessageBox.Show("Numero da Conta: " + contas[ultimo - 1].numero + "\nBanco: " + comboBox2.SelectedItem + "\nTipo de Conta: " + comboBox1.SelectedItem + "\nNome do Usuario: " + textBox1.Text);
            //this.Close();
            MessageBox.Show("numero da Conta: " + contas[ultimo - 1].Numero+ 
                "\nbanco " + comboBox1.SelectedItem + 
                "\ntipo de conta " + comboBox2.SelectedItem +
                "\nnnome do cliente: " + textBox1.Text);
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        //MessageBox.Show("numero da Conta: " + contas[ultimo-1].Numero +
        //"\nbanco " + comboBox2.SelectedItem +
        //"\ntipo de conta " + comboBox1.SelectedItem +
        //"\nnome do cliente: " + textBox1.Text);
            Form2 Outroform = new Form2(contas,acessada);
            Outroform.ShowDialog();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
