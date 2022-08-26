using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;


namespace ProgramaLoteria
{
    public partial class Form2 : Form
    {
        public Form2()
        {


            InitializeComponent();


            int numero1;
            int numero2;
            int numero3;
            int dinero;
            txtganada1.Text = "";
            txtganada2.Text = "";
            txtganada3.Text = "";
            var fecha = DateTime.Now;
            var Date = fecha.Date.ToString("dd-MM.yyyy");
            string cx = fecha.ToString("dd-MM-yyyy");
            Random rnd = new Random();
            numero1 = rnd.Next(0, 99);
            numero2 = rnd.Next(0, 99);
            numero3 = rnd.Next(0, 99);
            txtresultado1.Text = numero1.ToString();
            txtresultado2.Text = numero2.ToString();
            txtresultado3.Text = numero3.ToString();
            txtganada1.Text = "";
            txtganada2.Text = "";
            txtganada3.Text = "";

            if (Dato.loto1 == numero1)
            {
                MessageBox.Show("Ganaste EL PRIMER LOTO");
                dinero = Dato.cantidad1 * 60;
                txtganada1.Text = "RD$" + dinero.ToString();


            }
            else if (Dato.loto2 == numero2)
            {
                MessageBox.Show("Ganaste EL SEGUNDO LOTO");
                dinero = Dato.cantidad2 * 10;
                txtganada2.Text = "RD$" + dinero.ToString();
            }
            else if (Dato.loto3 == numero3)
            {
                MessageBox.Show("Ganaste EL TERCER LOTO");
                dinero = Dato.cantidad3 * 4;
                txtganada3.Text = "RD$" + dinero.ToString();
            }

            else if (numero1 == Dato.loto1 && numero2 == Dato.loto2 && numero3 == Dato.loto3)
            {
                MessageBox.Show("Ganaste LA TRIPLETA");
                txttripleta.Text = Convert.ToString(int.Parse(txtganada1.Text) + int.Parse(txtganada2.Text) + int.Parse(txtganada3.Text) * 50);
            }


            var dg = dataGridView1;
            dg.Rows.Add(txtresultado1.Text, txtresultado2.Text, txtresultado3.Text, cx);





        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {







        }

        private void button4_Click(object sender, EventArgs e)
        {


            int numero1;
            int numero2;
            int numero3;
            int dinero;

            txtganada1.Text = "";
            txtganada2.Text = "";
            txtganada3.Text = "";
            var fecha = DateTime.Now;
            var Date = fecha.Date.ToString("dd-MM.yyyy");
            string cx = fecha.ToString("dd-MM-yyyy");
            Random rnd = new Random();
            numero1 = rnd.Next(0, 99);
            numero2 = rnd.Next(0, 99);
            numero3 = rnd.Next(0, 99);
            txtresultado1.Text = numero1.ToString();
            txtresultado2.Text = numero2.ToString();
            txtresultado3.Text = numero3.ToString();
            txtganada1.Text = "";
            txtganada2.Text = "";
            txtganada3.Text = "";
            if (Dato.loto1 == numero1)
            {
                MessageBox.Show("Ganaste EL PRIMER LOTO");
                dinero = Dato.cantidad1 * 60;
                txtganada1.Text = "RD$" + dinero.ToString();


            }
            else if (Dato.loto2 == numero2)
            {
                MessageBox.Show("Ganaste EL SEGUNDO LOTO");
                dinero = Dato.cantidad2 * 10;
                txtganada2.Text = "RD$" + dinero.ToString();
            }
            else if (Dato.loto3 == numero3)
            {
                MessageBox.Show("Ganaste EL TERCER LOTO");
                dinero = Dato.cantidad3 * 4;
                txtganada3.Text = "RD$" + dinero.ToString();
            }

            else if (numero1 == Dato.loto1 && numero2 == Dato.loto2 && numero3 == Dato.loto3)
            {
                MessageBox.Show("Ganaste LA TRIPLETA");
                txttripleta.Text = Convert.ToString(int.Parse(txtganada1.Text) + int.Parse(txtganada2.Text) + int.Parse(txtganada3.Text) * 50);
            }


            var dg = dataGridView1;

            dg.Rows.Add(txtresultado1.Text, txtresultado2.Text, txtresultado3.Text, cx);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var dg = dataGridView1;
            int filas = dg.Rows.Count;
            int cont = 0;
            int valor;

            try
            {


                for (int i = 0; i <= filas; i++)
                {
                    valor = Convert.ToInt32(dg.Rows[i].Cells[0].Value);
                    for (int j = 0; j <= filas + 1; j++)
                    {

                        if (valor == Convert.ToInt32(dg.Rows[j].Cells[0].Value))
                        {
                            cont++;
                            txtrepetido.Text = valor.ToString();
                            dataGridView2.Rows.Add(txtrepetido.Text, cont);
                        }
                        else if (cont > 1)
                        {
                            txtrepetido.Text = valor.ToString();
                            dataGridView2.Rows.Add(txtrepetido.Text, cont);








                        }



                    }





                }
            }
            catch
            {

            }
        }
    }

}