using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox
        //    public Numero1[] numero1 = new Numero1[20];
        //numero[i].Saldo = i * 0.5;
            //}
        }
            private void button1_Click(object sender, EventArgs e)
        {
            //confirma
            double a = int.Parse(textBox1.Text);
           double b= a*0.5;

            MessageBox.Show("novo valor definido: " + b);
              //  textBox1.Text);
            this.Close();

        }
    }
}
