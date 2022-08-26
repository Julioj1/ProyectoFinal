using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaLoteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

            Dato.loto1 = Convert.ToInt16(txtloto1.Text);
            Dato.loto2 = Convert.ToInt16(txtloto2.Text);
            Dato.loto3 = Convert.ToInt16(txtloto3.Text);
            Dato.cantidad1 = Convert.ToInt16(txtcantidad1.Text);
            Dato.cantidad2 = Convert.ToInt16(txtcantidad2.Text);
            Dato.cantidad3 = Convert.ToInt16(txtcantidad3.Text);





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
