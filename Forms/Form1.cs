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
    public partial class Form1 : Form
    {
        // private string Contas;

        public int ultimo = 0;
        public Conta[] contas = new Conta[18];
        public Conta contaAcessada = new Conta();
        public Banco[] modelo = new Banco[18];
        public int acessada;

        public Form1()
        {
            InitializeComponent();
        }
        // private void button2_Click(object sender, EventArgs e)
        //private void button3_Click(object sender, EventArgs e)
        //{
        //Cliente form3 = new Cliente();
        //form3.Show();
        // ultimo++;

        //int numeroConta = int.Parse(textBox1.Text);
        //for (int i = 0; i < contas.Length; i++)
        //{
        //    if (contas[i].Numero == numeroConta)

        //    {
        //       Form2 form2 = new Form2(contas, i);
        //        form2.Show();
        //        break;



        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(contas, ultimo);
            form3.ShowDialog();
            ultimo++;
        }


        //private void button1_Click(object sender, EventArgs e)
        //  private void button2_Click(object sender, EventArgs e)
        //{
        //    int aux = ultimo;
        //    for (int i = aux; i < aux + 10; i++)
        //    {

        //        if (i > 2 && i <= 6)
        //        {
        //            contas[i] = new ContaCorrente();
        //            contas[i].Titular = "Caio" + i;
        //            //  contas[i].titular = "Caio" + i;
        //        }
        //        else if (i > 6 && i < 10)
        //        {
        //            contas[i] = new ContaPoupanca();
        //            contas[i].Titular = "Maria" + i;
        //            // contas[i].titular = "Maria" + i;
        //        }

        //        //contas[i].saldo = i * 1000;
        //        //contas[i].numero = i;
        //        contas[i].Saldo = i * 1000;
        //        contas[i].Numero = i;

        //        ultimo++;
        //    }
        //    button2.Enabled = false;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //  Conta
            Conta login1 = new Conta();
            //   contas[acessada].saca(int.Parse(textBox8.Text));
            contas[acessada].saca(int.Parse(textBox1.Text));
            //    //login1.
            login1.Numero = (int.Parse(textBox1.Text));

            if (login1.VerificaLogin1())
            {
                this.Hide();
                Form2 Outroform2 = new Form2(contas, acessada);
                Outroform2.ShowDialog();

                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show(
             "esse numero de conta nao existe", "erro",
                     MessageBoxButtons.OK);
            }
        }
        //Form3 form3 = new Form3(contas, ultimo);
        //form3.Show();
        //ultimo++;
        //}


        private void button4_Click(object sender, EventArgs e)
        {


            gerente login = new gerente();
            login.Senha = textBox2.Text;

            if (login.VerificaLogin())
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();

            }
            else
            {
                MessageBox.Show("senha incorreta ", "erro",
                    MessageBoxButtons.OK);
            }
            Gerente Outroform = new Gerente();
            Outroform.ShowDialog();
        }

        //    private void textBox1_TextChanged(object sender, EventArgs e)
        //    {

        //    }
        //}
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(contas, ultimo);
            form3.Show();
            ultimo++;
         }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
