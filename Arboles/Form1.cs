using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arbol A = new Arbol();
             A.Insertar(int.Parse(textBox1.Text));
            textBox6.Text +="nodo = "+ Convert.ToString(A.gobla) + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arbol A = new Arbol();
           // Nodo Rama = A.Actualizar(null, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
           // textBox6.Text += Convert.ToString(Rama.Dato) + Environment.NewLine;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arbol A = new Arbol();
          //  A.Eliminarnodo(null, Convert.ToInt32(textBox2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
